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
        private GameObject TempTrans;
        [SerializeField]
        private IntVariable HealthRef;
        [SerializeField]
        private IntVariable BaseHealthRef;
        private int health;
        [SerializeField]
        private Matthew.GameEvent OnMinionDeath;
        [SerializeField]
        private UnityEngine.Events.UnityEvent OnMinionRespawn;
        [SerializeField]
        Animator animator;
        [SerializeField]
        public string target;
        private bool IsAlive;

        void Start()
        {
            animator = GetComponent<Animator>();
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
            else if (other.CompareTag(target))
            {
                animator.SetBool("InRange",true);
                var temp = gameObject;
                Destroy(temp, 3);
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag(target))
            {
                animator.SetBool("InRange", false);
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
            TempTrans = gameObject;
            Destroy(TempTrans);
        }
        private void Respawn()
        {
            if (Time.time >= RespawnTime)
            {
                IsAlive = true;
                health = BaseHealthRef.Val;
                //gameObject.GetComponent<MeshRenderer>().enabled = true;
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

