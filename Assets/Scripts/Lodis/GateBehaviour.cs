using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
namespace Lodis
{



    public class GateBehaviour : MonoBehaviour
    {
        //each camera would have a specific cinemachine camera
        //the gate would know about the current camera and the one it should transition to
        [Cinemachine.TagField, SerializeField]
        public string compareTag;
        [SerializeField]
        Transform SpawnPoint1;
        [SerializeField]
        Transform SpawnPoint2;
        [SerializeField]
        private Matthew.Global Global;
        [SerializeField]
        private CinemachineVirtualCamera CurrentCam;
        [SerializeField]
        private CinemachineVirtualCamera TransitionCam;

        [SerializeField]
        UnityEngine.Events.UnityEvent OnTriggerEnterResponse;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player1"))
            {
                Global.Tag = "Player2";
                Global.TeleportPlayerTo(SpawnPoint2);
                OnTriggerEnterResponse.Invoke();
            }
            else if (other.CompareTag("Player2"))
            {
                Global.Tag = "Player1";
                Global.TeleportPlayerTo(SpawnPoint1);
                OnTriggerEnterResponse.Invoke();
            }
            else if (other.CompareTag("Bullet"))
            {
                return;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            GetComponent<Collider>().isTrigger = false;
        }
        public void Open()
        {
            GetComponent<Collider>().isTrigger = true;
        }
        public void Close()
        {
            GetComponent<Collider>().isTrigger = false;
        }
        public void ToggleCameras()
        {
            CurrentCam.enabled = !CurrentCam.enabled;
            TransitionCam.enabled = !TransitionCam.enabled;
        }

    }
}