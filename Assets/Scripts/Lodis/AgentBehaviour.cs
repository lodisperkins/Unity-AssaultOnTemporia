using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace Lodis
{

    public class AgentBehaviour : MonoBehaviour
    {
        [SerializeField]
        private string compareTag;
        [SerializeField]
        private string horizontalAxis;
        [SerializeField]
        private string verticalAxis;
        [SerializeField]
        private string Fire;
        [SerializeField]
        private int speed;
        private Vector3 velocity;
        private CharacterController controller;
        public bool hasKey;
<<<<<<< Updated upstream
        
=======
        public GameObject Ball;
        public int DropDisplacement;
>>>>>>> Stashed changes
        [SerializeField]
        UnityEngine.Events.UnityEvent OnTriggerEnterResponse;
        [SerializeField]
        UnityEngine.Events.UnityEvent KeyDropped;
        
        private void Start()
        {
            hasKey = false;
            controller = GetComponent<CharacterController>();
        }
      
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(compareTag))
            {
                hasKey = true;
                KeyDropped.AddListener(other.GetComponent<KeyBehaviour>().CloseGates);
                Carry(other.gameObject);
            }
        }
        /// <summary>
        /// when a player picks up and object, the object is no lobger visible
        /// and is childed to the players transform
        /// </summary>
        /// <param name="obj"></param>
        public void Carry(GameObject obj)
        {
<<<<<<< Updated upstream
=======
            Ball = obj;
            PickUp(Ball);
        }

        public void PickUp(GameObject obj)
        {
>>>>>>> Stashed changes
            obj.GetComponent<MeshRenderer>().enabled = false;
            obj.GetComponent<SphereCollider>().enabled = false;
            obj.GetComponent<Transform>().SetParent(transform);
        }
<<<<<<< Updated upstream
=======
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
>>>>>>> Stashed changes
        // Update is called once per frame
        void Update()
        {
            velocity = new Vector3(Input.GetAxis(horizontalAxis), 0, Input.GetAxis(verticalAxis));
            controller.SimpleMove(velocity*speed);
<<<<<<< Updated upstream
=======
            if(Input.GetButtonDown(Fire))
            {
                Drop();
            }
>>>>>>> Stashed changes
        }
    }
}


