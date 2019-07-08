using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis.Movement
{
    public class PlayerMovementBehaviour : MonoBehaviour
    {
        [SerializeField]
        private IntVariable SpeedRef;
        [SerializeField]
        private IntVariable DashSpeed;
        private int speed;
        [SerializeField]
        private VectorVariable Velocity;
        [SerializeField]
        private VectorVariable RotationRef;
        [SerializeField]
        private float DashCooldown;
        private float DashTime;
        private bool Dashing;
        private Vector3 Rotation;
        private CharacterController Controller;
        [SerializeField]
        private Matthew.GameEvent OnDashBegin;
        [SerializeField]
        private Matthew.GameEvent OnDashEnd;
        private VelocityDecay DashDecay;
        private Vector3 DashVelocity;
        [SerializeField]
        private float DashEnd;
        // Use this for initialization
        void Start()
        {
            Dashing = false;
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
        public void Dash()
        {
            if (Time.time >= DashTime)
            {
                DashTime = DashCooldown + Time.time;
                Dashing = true;
                DashVelocity = Velocity.Val * DashSpeed.Val;
                DashDecay = new VelocityDecay(2,DashVelocity);
                OnDashBegin.Raise(gameObject);
            }
        }
        public void CancelDash()
        {
            Dashing = false;
            OnDashEnd.Raise(gameObject);
        }

        // Update is called once per frame
        void Update()
        {
            if (Dashing)
            {
                Vector3 velocity =DashDecay.updateVelocity(Time.deltaTime);
                Controller.SimpleMove(velocity);
                if(velocity.magnitude <= DashEnd)
                {
                    CancelDash();
                }
            }
            else
            {
                Controller.SimpleMove(Velocity.Val * speed);
                UpdateForward();
                transform.forward = Rotation;
            }
        }
    }
}
