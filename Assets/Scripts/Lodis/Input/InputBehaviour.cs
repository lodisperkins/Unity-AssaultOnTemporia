using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis.PlayerInput
{
        public class InputBehaviour : MonoBehaviour
        {
            [SerializeField]
            private string HorizontalAxis;
            [SerializeField]
            private string VerticalAxis;
            [SerializeField]
            private string HorizontalAxis2;
            [SerializeField]
            private string VerticalAxis2;
            [SerializeField]
            private string Fire;
            [SerializeField]
            private string Dash;
            [SerializeField]
            private VectorVariable Movement;
            [SerializeField]
            private VectorVariable Rotation;
            [SerializeField]
            private Matthew.GameEvent OnFirePressed;
            [SerializeField]
            private Matthew.GameEvent OnDashPressed;
            // Update is called once per frame
            void Update()
            {
                Movement.Val = new Vector3(Input.GetAxis(VerticalAxis), 0, Input.GetAxis(horizontalAxis));
                Rotation.Val = new Vector3(Input.GetAxis(VerticalAxis2), 0, Input.GetAxis(HorizontalAxis2));
                if (Input.GetButtonDown(Fire))
                {
                    OnFirePressed.Raise(gameObject);
                    Debug.Log(Fire + "has fired");
                }
                if(Input.GetButtonDown(Dash))
                {
                    OnDashPressed.Raise(this.gameObject);
                    Debug.Log(Fire + "has dashed");
                }
            }
        }
    
}
