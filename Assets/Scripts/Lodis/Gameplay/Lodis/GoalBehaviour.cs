using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
namespace Lodis.Gameplay
{
    public class GoalBehaviour : MonoBehaviour
    {
        [SerializeField]
        private string CompareTag;
        [SerializeField]
        private Matthew.GameEvent GameWon;
        [SerializeField]
        CinemachineVirtualCamera CurrentCam;
        [SerializeField]
        CinemachineVirtualCamera StartCam;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(CompareTag))
            {
                GameWon.Raise(gameObject);
            }
        }
        public void ToggleCameras()
        {
            CurrentCam.enabled = false;
            StartCam.enabled = true;
        }
    }
}
