using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis.Gameplay
{
    public class HealthBehaviour : MonoBehaviour {

        [SerializeField]
        private IntVariable RespawnDelayRef;
        private float RespawnDelay;
        private float RespawnTime;
        [SerializeField]
        private IntVariable HealthRef;
        int health;
        [SerializeField]
        UnityEngine.Events.UnityEvent OnPlayerDeath;
        [SerializeField]
        UnityEngine.Events.UnityEvent OnPlayerRespawn;
        bool IsAlive;
    // Use this for initialization
        void Start() {
            RespawnDelay = RespawnDelayRef.Val;
            health = HealthRef.Val;
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
                CheckHealth();
            }
        }
        private void CheckHealth()
        {
            if (health <= 0)
            {
                OnPlayerDeath.Invoke();
                Die();
            }
        }
        public void Die()
        {
            IsAlive = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<CharacterController>().enabled = false;
            RespawnTime = RespawnDelay + Time.time;
        }
        private void Respawn()
        {
            if (Time.time >= RespawnTime)
            {
                IsAlive = true;
                health = HealthRef.Val;
                gameObject.GetComponent<MeshRenderer>().enabled = true;
                gameObject.GetComponent<BoxCollider>().enabled = true;
                gameObject.GetComponent<CharacterController>().enabled = true;
                OnPlayerRespawn.Invoke();
            }
        }
        // Update is called once per frame
        void Update() {
            if (IsAlive == false)
            {
                Respawn();
                return;
            }
        }
    }
}
