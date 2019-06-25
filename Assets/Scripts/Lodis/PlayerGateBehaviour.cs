using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis
{
    public class PlayerGateBehaviour : MonoBehaviour {
        [SerializeField]
        UnityEngine.Events.UnityEvent OnTransition;
        // Use this for initialization
        void Start() {

        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Gate"))
            {
                OnTransition.Invoke();
            }
        }

        // Update is called once per frame
        void Update() {

        }
    }
}
