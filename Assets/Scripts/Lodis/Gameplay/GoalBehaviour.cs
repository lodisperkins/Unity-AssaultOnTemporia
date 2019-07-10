using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
namespace Lodis.Gameplay
{
    public class GoalBehaviour : MonoBehaviour
    {
        [SerializeField]
        private string Tag;
        [SerializeField]
        private Matthew.GameEvent GameWon;
        [SerializeField]
        private CinemachineVirtualCamera CurrentCam;
        [SerializeField]
        private CinemachineVirtualCamera StartCam;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(Tag))
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
