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
        private CinemachineVirtualCamera currentCam;
        [SerializeField]
        private CinemachineVirtualCamera transitionCam;

        [SerializeField]
        UnityEngine.Events.UnityEvent OnTriggerEnterResponse;
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player1")
            {
                Global.Tag = "Player2";
                Global.TeleportPlayerTo(SpawnPoint2);
            }
            else
            {
                Global.Tag = "Player1";
                Global.TeleportPlayerTo(SpawnPoint1);
            }
            OnTriggerEnterResponse.Invoke();
        }
        private void OnTriggerExit(Collider other)
        {
            GetComponent<Collider>().isTrigger = false;
        }
        public void Open()
        {
            GetComponent<Collider>().isTrigger = true;
        }
        public void ToggleCameras()
        {
            currentCam.enabled = !currentCam.enabled;
            transitionCam.enabled = !transitionCam.enabled;
        }

    }
}