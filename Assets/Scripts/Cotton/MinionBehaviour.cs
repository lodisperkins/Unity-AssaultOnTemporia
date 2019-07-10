using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    

    public class MinionBehaviour : MonoBehaviour
    {
        public Wave[] Waves; // class to hold information per wave
        public Transform[] SpawnPoints;
        public float TimeBetweenEnemies = 2f;

        private int _totalEnemiesInCurrentWave;
        private int _enemiesInWaveLeft;
        private int _spawnedEnemies;

        private int _currentWave;
        private int _totalWaves;

        void Start()
        {
            _currentWave = -1; // avoid off by 1
            _totalWaves = Waves.Length - 1; // adjust, because we're using 0 index

            StartNextWave();
        }

        [System.Serializable]
        public class Wave
        {
            public int EnemiesPerWave;
            public GameObject Enemy;
        }

        void StartNextWave()
        {
            _currentWave++;

            // win
            if (_currentWave > _totalWaves)
            {
                return;
            }

            _totalEnemiesInCurrentWave = Waves[_currentWave].EnemiesPerWave;
            _enemiesInWaveLeft = 0;
            _spawnedEnemies = 0;

            StartCoroutine(SpawnEnemies());
        }

        // Coroutine to spawn all of our enemies
        IEnumerator SpawnEnemies()
        {
            GameObject enemy = Waves[_currentWave].Enemy;
            while (_spawnedEnemies < _totalEnemiesInCurrentWave)
            {
                _spawnedEnemies++;
                _enemiesInWaveLeft++;

                int spawnPointIndex = Random.Range(0, SpawnPoints.Length);

                // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
                Instantiate(enemy, position: SpawnPoints[spawnPointIndex].position, rotation: SpawnPoints[spawnPointIndex].rotation);
                yield return new WaitForSeconds(seconds: TimeBetweenEnemies);
            }
            yield return null;
        }

        // called by an enemy when they're defeated
        public void EnemyDefeated()
        {
            _enemiesInWaveLeft--;

            // We start the next wave once we have spawned and defeated them all
            if (_enemiesInWaveLeft == 0 && _spawnedEnemies == _totalEnemiesInCurrentWave)
            {
                StartNextWave();
            }
        }
    }

