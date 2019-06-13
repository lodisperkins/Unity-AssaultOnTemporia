using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GoalBehaviour : MonoBehaviour {
    [SerializeField]
    private string CompareTag;
    [SerializeField]
    private Matthew.GameEvent Restart;
    [SerializeField]
    CinemachineVirtualCamera CurrentCam;
    [SerializeField]
    CinemachineVirtualCamera StartCam;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(CompareTag))
        {
            CurrentCam.enabled = false;
            StartCam.enabled = true;
            Restart.Raise();
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
