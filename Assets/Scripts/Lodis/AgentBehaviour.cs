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
        private string horizontalAxis;
        [SerializeField]
        private string verticalAxis;

        private CharacterController controller;
        private void Start()
        {
            controller = GetComponent<CharacterController>();
        }
        // Update is called once per frame
        void Update()
        {
            controller.SimpleMove(new Vector3(Input.GetAxis(horizontalAxis), 0, Input.GetAxis(verticalAxis))*5);
        }
    }
}


