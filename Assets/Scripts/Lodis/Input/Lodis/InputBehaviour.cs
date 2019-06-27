using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis.PlayerInput
{
        public class InputBehaviour : MonoBehaviour
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
            private string Dash;
            [SerializeField]
            VectorVariable Movement;
            [SerializeField]
            VectorVariable Rotation;
            [SerializeField]
            UnityEngine.Events.UnityEvent OnFirePressed;
            [SerializeField]
            Matthew.GameEvent OnDashPressed;
            // Update is called once per frame
            void Update()
            {
                Movement.Val = new Vector3(Input.GetAxis(verticalAxis), 0, Input.GetAxis(horizontalAxis));
                Rotation.Val = new Vector3(Input.GetAxis(verticalAxis2), 0, Input.GetAxis(horizontalAxis2));
                if (Input.GetButtonDown(Fire))
                {
                    OnFirePressed.Invoke();
                    Debug.Log(Fire + "has fired");
                }
                if(Input.GetButtonDown(Dash))
                {

                }
            }
        }
    
}
