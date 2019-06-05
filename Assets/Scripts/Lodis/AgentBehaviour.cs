using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace Lodis
{

    public class AgentBehaviour : MonoBehaviour
    {
        private Vector3 playerInput;
        [SerializeField]
        private string compareTag;
        [SerializeField]
        private string horizontalAxis;
        [SerializeField]
        private string verticalAxis;
        [SerializeField]
        private int speed;
        private Vector3 velocity;
        private CharacterController controller;
        public bool hasKey;
        [SerializeField]
        UnityEngine.Events.UnityEvent OnTriggerEnterResponse;
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
                OnTriggerEnterResponse.Invoke();
            }
        }
        public void Carry(GameObject obj)
        {
            obj.GetComponent<MeshRenderer>().enabled = false;
            obj.GetComponent<SphereCollider>().enabled = false;
            obj.GetComponent<Transform>().SetParent(transform);
        }
        // Update is called once per frame
        void Update()
        {
            velocity = new Vector3(Input.GetAxis(horizontalAxis), 0, Input.GetAxis(verticalAxis));
            controller.SimpleMove(velocity*speed);
        }
    }
}


