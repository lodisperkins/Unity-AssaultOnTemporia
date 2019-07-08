using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
namespace Lodis.Gameplay
{
    public class CameraBehaviour : MonoBehaviour
    {
        CinemachineVirtualCamera camera;
        [SerializeField]
        Matthew.GameEvent CameraOn;
        private void Start()
        {
            camera = GetComponent<CinemachineVirtualCamera>();
        }
        private void OnEnable()
        {
            CameraOn.Raise(gameObject);
        }
        public void ToggleCamera()
        {
            camera.enabled = !camera.enabled;
        }
    }
}
