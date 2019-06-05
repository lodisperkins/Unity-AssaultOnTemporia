using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
namespace Lodis
{



    public class GateBehaviour : MonoBehaviour
    {
        [Cinemachine.TagField, SerializeField]
        string compareTag;
        [SerializeField]
        private CinemachineVirtualCamera currentCam;
        [SerializeField]
        private CinemachineVirtualCamera transitionCam;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(compareTag))
            {
                currentCam.enabled = !currentCam.enabled;
                transitionCam.enabled = !transitionCam.enabled;
            }
        }

    }
}