using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace Lodis
{

    public class AgentBehaviour : MonoBehaviour
    {
        [SerializeField]
        private string horizontalAxis;
        [SerializeField]
        private string verticalAxis;
        [SerializeField]
        private string Fire;
        [SerializeField]
        private int speed;
        [SerializeField]
        private GameObject BulletEmitter;
        [SerializeField]
        private float RespawnDelay;
        private float RespawnTime;
        [SerializeField]
        private int health;
        private Vector3 velocity;
        private CharacterController controller;
        public bool hasKey;
        public bool HasKey
        {
            get { return hasKey; }
        }
        public bool isAlive;
        public GameObject Ball;
        public int DropDisplacement;
       
        [SerializeField]
        UnityEngine.Events.UnityEvent OnTriggerEnterResponse;
        [SerializeField]
        UnityEngine.Events.UnityEvent KeyDropped;
        
        private void Start()
        {
            isAlive = true;
            health = 3;
            hasKey = false;
            controller = GetComponent<CharacterController>();
        }
      
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Key"))
            {
                hasKey = true;
                KeyDropped.AddListener(other.GetComponent<KeyBehaviour>().CloseGates);
                Carry(other.gameObject);
            }
            else if (other.CompareTag("Bullet"))
            {
                TakeDamage();
            }
        }
        /// <summary>
        /// when a player picks up and object, the object is no lobger visible
        /// and is childed to the players transform
        /// </summary>
        /// <param name="obj"></param>
        public void Carry(GameObject obj)
        {
            Ball = obj;
            PickUp(Ball);
        }
        private void TakeDamage()
        {
            health -= 1;
            if (health <= 0)
            {
                if (hasKey == true)
                {
                    Drop();
                }
                Die();
            }
        }
        public void PickUp(GameObject obj)
        {
            obj.GetComponent<MeshRenderer>().enabled = false;
            obj.GetComponent<SphereCollider>().enabled = false;
            obj.GetComponent<Transform>().SetParent(transform);
        }
        public void Drop()
        {
            var obj = Ball;
            KeyDropped.Invoke();
            obj.GetComponent<MeshRenderer>().enabled = true;
            obj.GetComponent<SphereCollider>().enabled = true;
            obj.GetComponent<Transform>().SetParent(null);
            obj.GetComponent<Transform>().position += new Vector3(DropDisplacement, 0, 0);
            hasKey = false;
            
        }
        public void PullTrigger()
        {
            BulletBehaviour Gun = BulletEmitter.GetComponent<BulletBehaviour>();
            Gun.Fire();
        }
        public void Die()
        {
            isAlive = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<CharacterController>().enabled = false;
            RespawnTime = RespawnDelay + Time.time;
        }
        private void Respawn()
        {
            if(Time.time >= RespawnTime)
            {
                isAlive = true;
                health = 3;
                gameObject.GetComponent<MeshRenderer>().enabled = true;
                gameObject.GetComponent<BoxCollider>().enabled = true;
                gameObject.GetComponent<CharacterController>().enabled = true;
            }
        }
        // Update is called once per frame
        void Update()
        {
            if (isAlive == false)
            {
                Respawn();
                return;
            }
            velocity = new Vector3(Input.GetAxis(horizontalAxis), 0, Input.GetAxis(verticalAxis));
            controller.SimpleMove(velocity*speed);
            if(Input.GetButtonDown(Fire))
            {
                PullTrigger();
                Debug.Log(Fire + "has fired");
            }
        }
    }
}


