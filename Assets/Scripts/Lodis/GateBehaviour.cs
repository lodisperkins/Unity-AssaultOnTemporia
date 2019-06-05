using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class GateBehaviour : MonoBehaviour {

    [SerializeField]
    private CinemachineVirtualCamera currentCam;
    [SerializeField]
    private CinemachineVirtualCamera transitionCam;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentCam.enabled = !currentCam.enabled;
            transitionCam.enabled = !transitionCam.enabled;
        }
    }

}
