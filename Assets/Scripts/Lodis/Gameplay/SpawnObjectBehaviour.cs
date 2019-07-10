using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis.Gameplay
{
    public class SpawnObjectBehaviour : MonoBehaviour
    {

        private List<GameObject> GameObjects;
        [SerializeField]
        private int Timer;
        [SerializeField]
        private int SpawnLimit;
        [SerializeField]
        private Transform SpawnPoint;
        [SerializeField]
        private GameObject ObjectSpawning;
        //Spawns gameobjects upon spawn points creattion
        void Start()
        {
            GameObjects = new List<GameObject>();
            SpawnObject();
        }
        //Starts the spawn object coroutine
        void SpawnObject()
        {
            StartCoroutine(Spawn());
        }
        /// <summary>
        /// Creates a temprary transform for the gameobjects to exist 
        /// independently and adds the gameobjects to a list
        /// </summary>
        /// <returns></returns>
        private IEnumerator Spawn()
        {
            for (int i = 0; i <= SpawnLimit; i++)
            {
                GameObject TempTransform = new GameObject();
                TempTransform.transform.position = SpawnPoint.position;
                GameObject NewObject = Instantiate(ObjectSpawning, TempTransform.transform);

                GameObjects.Add(NewObject);
                yield return new WaitForSeconds(Timer);
            }
        }
    }
}
