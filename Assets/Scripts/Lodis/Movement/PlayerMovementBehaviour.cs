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
        private VectorVariable RotationRef;
        private Vector3 Rotation;
        private CharacterController Controller;
        // Use this for initialization
        void Start()
        {
            speed = SpeedRef.Val;
            Rotation = new Vector3();
            Controller = GetComponent<CharacterController>();
        }
        public void DisableMovement()
        {
            speed = 0;
        }
        private void UpdateForward()
        {
            if(RotationRef.Val.magnitude >0)
            {
                Rotation =RotationRef.Val;
            }
        }
        public void EnableMovement()
        {
            speed = SpeedRef.Val;
        }
        // Update is called once per frame
        void Update()
        {
            Controller.SimpleMove(Velocity.Val * speed);
            UpdateForward();
            transform.forward = Rotation;
        }
    }
}
