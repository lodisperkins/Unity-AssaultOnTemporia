using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CherryBombBehaviour : MonoBehaviour {
    Animator animator;
    [SerializeField]
    List<CinemachineVirtualCamera> cameras;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
    public void UpdateCameras()
    {
        foreach (var Cam in cameras)
        {
            if(Cam.enabled)
            {
                animator.SetBool(Cam.name, true);
            }
            else
            {
                animator.SetBool(Cam.name, false);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        //might be bad
        UpdateCameras();
    }
}
