using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
namespace Lodis.Gameplay
{

    public class GateBehaviour : MonoBehaviour
    {
        //each camera would have a specific cinemachine camera
        //the gate would know about the current camera and the one it should transition to
        [Cinemachine.TagField, SerializeField]
        public GameObject KeyHolder;
        [SerializeField]
        private Transform TransitionSpawn1;
        [SerializeField]
        private Transform TransitionSpawn2;
        [SerializeField]
        private Transform AreaSpawn1;
        [SerializeField]
        private Transform AreaSpawn2;
        [SerializeField]
        private Matthew.Global Global;
        [SerializeField]
        private CinemachineVirtualCamera CurrentCam;
        [SerializeField]
        private CinemachineVirtualCamera TransitionCam;
        [SerializeField]
        private Matthew.GameEvent OnGateEnter;
        [SerializeField]
        private Matthew.GameEvent OnGateExit;
        private void OnTriggerEnter(Collider other)
        {
            //needs to be made better
            if (other.CompareTag(KeyHolder.tag))
            {
                MoveToNextArea();
            }
            else
            {
                RemainInArea(other.tag);
            }
        }
        private void MoveToNextArea()
        {
            if (KeyHolder.tag == "Player1")
            {
                Global.Tag = "Player2";
                Global.TeleportPlayerTo(TransitionSpawn2);
                OnGateEnter.Raise(gameObject);
            }
            else if (KeyHolder.tag =="Player2")
            {
                Global.Tag = "Player1";
                Global.TeleportPlayerTo(TransitionSpawn1);
                OnGateEnter.Raise(gameObject);
            }
        }
        private void RemainInArea(string obj)
        {
            if (obj == "Player1")
            {
                Global.Tag = "Player1";
                Global.TeleportPlayerTo(AreaSpawn1);
            }
            else if (obj == "Player2")
            {
                Global.Tag = "Player2";
                Global.TeleportPlayerTo(AreaSpawn2);
            }
            else
            {
                return;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.tag!= KeyHolder.tag)
            {
                return;
            }
            OnGateExit.Raise(gameObject);
             
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
        private void Start()
        {
            Close();
        }

        public void SetColliderToTrigger()

        {
            GetComponent<Collider>().isTrigger = false;
        }

    }
}