using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis.Gameplay
{
    public class PlayerItemBehaviour :MonoBehaviour
    {
        public GameObject Ball;
        public int DropDisplacement;
        public bool HasKey;
        [SerializeField]
        private GameObject Goal;
        [SerializeField]
        private Vector3 ThrowingForce;
        [SerializeField]
        private UnityEngine.Events.UnityEvent KeyDropped;
        [SerializeField]
        private Matthew.GameEvent Victory;
        // Use this for initialization
        void Start()
        {
            HasKey = false;
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Key"))
            {
                HasKey = true;
                KeyDropped.AddListener(other.GetComponent<KeyBehaviour>().CloseGates);
                Carry(other.gameObject);
            }
            else if(other.CompareTag("Win Area"))
            {
                GetComponent<Lodis.PlayerInput.InputBehaviour>().enabled = false;
                GetComponent<Lodis.Movement.PlayerMovementBehaviour>().DisableMovement();
                transform.LookAt(Goal.transform);
                Victory.Raise(gameObject);
            }
        }
        public void Carry(GameObject obj)
        {
            Ball = obj;
            PickUp(Ball);
        }
        public void PickUp(GameObject obj)
        {
            obj.GetComponent<MeshRenderer>().enabled = false;
            obj.GetComponent<SphereCollider>().enabled = false;
            obj.GetComponent<SphereCollider>().enabled = false;
        }
        public void Drop()
        {
            if (HasKey)
            {
                var obj = Ball;
                KeyDropped.Invoke();
                obj.GetComponent<MeshRenderer>().enabled = true;
                obj.GetComponent<SphereCollider>().enabled = true;
                
                HasKey = false;
            }
            else
            {
                return;
            }
        }
        [ContextMenu("Throw")]
        public void Throw()
        {
            Drop();
            Ball.GetComponent<Transform>().position += new Vector3(0, 0, DropDisplacement);
            Ball.AddComponent<Rigidbody>();
            Ball.GetComponent<SphereCollider>().isTrigger = false;
            var temporary_RigidBody = Ball.GetComponent<Rigidbody>();
            temporary_RigidBody.AddForce(ThrowingForce);
        }
        private void Update()
        {
            if(HasKey)
            {
                Ball.transform.position = transform.position;
            }
        }
    }
}
