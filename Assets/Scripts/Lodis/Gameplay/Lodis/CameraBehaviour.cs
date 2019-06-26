using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraBehaviour : MonoBehaviour {
    CinemachineVirtualCamera camera;
    private void Start()
    {
        camera = GetComponent<CinemachineVirtualCamera>();
    }
    public void ToggleCamera()
    {
        camera.enabled = !camera.enabled;
    }
}
