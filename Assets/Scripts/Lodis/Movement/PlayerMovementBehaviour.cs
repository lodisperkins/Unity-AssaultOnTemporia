using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis.Movement
{
    public class PlayerMovementBehaviour : MonoBehaviour
    {
        [SerializeField]
        private IntVariable SpeedRef;
        int speed;
        [SerializeField]
        private VectorVariable Velocity;
        [SerializeField]
        private VectorVariable Rotation;
        private CharacterController Controller;
        // Use this for initialization
        void Start()
        {
            speed = SpeedRef.Val;
            Controller = GetComponent<CharacterController>();
        }
        public void DisableMovement()
        {
            speed = 0;
        }
        public void EnableMovement()
        {
            speed = SpeedRef.Val;
        }
        // Update is called once per frame
        void Update()
        {
            Controller.SimpleMove(Velocity.Val * speed);
            transform.forward = Rotation.Val;
        }
    }
}
