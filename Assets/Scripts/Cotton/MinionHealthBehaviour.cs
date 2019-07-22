using Lodis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cotton.Gameplay
{
    public class MinionHealthBehaviour : MonoBehaviour
    {
        [SerializeField]
        private IntVariable RespawnDelayRef;
        private float RespawnDelay;
        private float RespawnTime;
        [SerializeField]
        private IntVariable HealthRef;
        [SerializeField]
        private IntVariable BaseHealthRef;
        private int health;
        [SerializeField]
        private Matthew.GameEvent OnMinionDeath;
        [SerializeField]
        private UnityEngine.Events.UnityEvent OnMinionRespawn;
        private bool IsAlive;

        void Start()
        {
            RespawnDelay = RespawnDelayRef.Val;
            health = BaseHealthRef.Val;
        }
        public void Restart()
        {
            RespawnDelay = RespawnDelayRef.Val;
            health = BaseHealthRef.Val;
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Bullet"))
            {
                TakeDamage(other.gameObject);
            }
        }
        private void TakeDamage(GameObject bullet)
        {
            if (CompareTag(bullet.GetComponent<BulletBehaviour>().shooter))
            {
                return;
            }
            else
            {
                health -= 1;
                HealthRef.Val = health;
                CheckHealth();
            }
        }
        private void CheckHealth()
        {
            if (health <= 0)
            {
                OnMinionDeath.Raise(gameObject);
                Die();
            }
        }
        public void Die()
        {
            IsAlive = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            RespawnTime = RespawnDelay + Time.time;
        }
        private void Respawn()
        {
            if (Time.time >= RespawnTime)
            {
                IsAlive = true;
                health = BaseHealthRef.Val;
                gameObject.GetComponent<BoxCollider>().enabled = true;
                OnMinionRespawn.Invoke();
            }
        }
        void Update()
        {
            if (IsAlive == false)
            {
                Respawn();
                return;
            }
        }
    }
}

