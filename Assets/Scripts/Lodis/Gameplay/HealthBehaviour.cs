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
        private float VulnerabilityDelay;
        private float VulnerabilityTime;
        [SerializeField]
        private IntVariable HealthRef;
        [SerializeField]
        private IntVariable BaseHealthRef;
        private int health;
        [SerializeField]
        private Matthew.GameEvent OnPlayerDeath;
        [SerializeField]
        private Matthew.GameEvent OnHealthChanged;
        [SerializeField]
        private UnityEngine.Events.UnityEvent OnPlayerRespawn;
        private bool IsAlive;
        [SerializeField]
        private bool IsInvincible;
    // Use this for initialization
        void Start() {
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
            else if(IsInvincible)
            {
                return;
            }
            else
            {
                health -= 1;
                HealthRef.Val = health;
                OnHealthChanged.Raise(HealthRef);
                CheckHealth();
            }
        }
        private void CheckHealth()
        {
            if (health <= 0)
            {
                OnPlayerDeath.Raise(gameObject);
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
                health = BaseHealthRef.Val;
                gameObject.GetComponent<MeshRenderer>().enabled = true;
                gameObject.GetComponent<BoxCollider>().enabled = true;
                gameObject.GetComponent<CharacterController>().enabled = true;
                OnPlayerRespawn.Invoke();
            }
        }
        public void MakeInvincible(float time)
        {
            VulnerabilityDelay = time;
            VulnerabilityTime = VulnerabilityDelay + Time.time;
            IsInvincible = true;
        }
        public void MakeVulnerable()
        {
            if (Time.time >= VulnerabilityTime)
            {
                IsInvincible = false;
            }
        }
        // Update is called once per frame
        void Update() {
            if (IsAlive == false)
            {
                Respawn();
                return;
            }
            if(IsInvincible)
            {
                MakeVulnerable();
            }
        }
    }
}
