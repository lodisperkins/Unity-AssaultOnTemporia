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
        private string horizontalAxis2;
        [SerializeField]
        private string verticalAxis2;
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
        public bool HasKey;
        public bool Transitioning;
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
            health = 6;
            HasKey = false;
            controller = GetComponent<CharacterController>();
        }
      
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Key"))
            {
                HasKey = true;
                KeyDropped.AddListener(other.GetComponent<KeyBehaviour>().CloseGates);
                Carry(other.gameObject);
            }
            else if (other.CompareTag("Bullet"))
            {
                TakeDamage(other.gameObject);
            }
        }
        private void OnTriggerExit(Collider other)
        {
            Transitioning = false;
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
        public void AreaTransition()
        {
            Transitioning = true;
        }
        public void AreaTransitonDone()
        {
            Transitioning = false;
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
                if (HasKey == true)
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
            HasKey = false;
        }
        public void PullTrigger()
        {
            GunBehaviour Gun = BulletEmitter.GetComponent<GunBehaviour>();
            Gun.Player = tag;
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
                health = 6;
                gameObject.GetComponent<MeshRenderer>().enabled = true;
                gameObject.GetComponent<BoxCollider>().enabled = true;
                gameObject.GetComponent<CharacterController>().enabled = true;
            }
        }
        public void Restart()
        {
            if(this.HasKey ==  true)
            {
                Drop();
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
            if(Transitioning == true)
            {
                controller.SimpleMove(velocity * speed);
                return;
            }
            else if(Transitioning == false)
            {
                velocity = new Vector3(Input.GetAxis(verticalAxis), 0, Input.GetAxis(horizontalAxis));
                controller.SimpleMove(velocity*speed);
                transform.forward = new Vector3(Input.GetAxis(verticalAxis2), 0, Input.GetAxis(horizontalAxis2));
                Debug.Log("Rotation is" + Input.GetAxis(horizontalAxis2) + ",0," + Input.GetAxis(verticalAxis2));
                if (Input.GetButtonDown(Fire))
                {
                    PullTrigger();
                    Debug.Log(Fire + "has fired");
                }
            }
        }
    }
}


