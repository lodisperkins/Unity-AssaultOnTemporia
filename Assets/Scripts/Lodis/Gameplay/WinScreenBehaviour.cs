using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis
{
    public class WinScreenBehaviour : MonoBehaviour
    {
        [SerializeField]
        Matthew.GameEvent Restart;
        [SerializeField]
        private string Select;
        [SerializeField]
        private string Cancel;
        // Update is called once per frame
        void Update()
        {
            if(Input.GetButtonDown(Select))
            {
                Debug.Log("Select pressed");
                Restart.Raise(gameObject);
            }
            if(Input.GetButtonDown(Cancel))
            {
                Debug.Log("Cancel pressed");
                Application.Quit();
            }
        }
    }
}
