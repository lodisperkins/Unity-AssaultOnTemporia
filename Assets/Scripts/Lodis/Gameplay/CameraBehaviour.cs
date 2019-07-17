using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
namespace Lodis.Gameplay
{
    public class CameraBehaviour : MonoBehaviour
    {
        private CinemachineVirtualCamera Camera;
        [SerializeField]
        private Matthew.GameEvent CameraOn;
        private void Start()
        {
            Camera = GetComponent<CinemachineVirtualCamera>();
        }
        private void OnEnable()
        {
            if(CameraOn == null)
            {
                return;
            }
            CameraOn.Raise(gameObject);
        }
        public void ToggleCamera()
        {
            Camera.enabled = !Camera.enabled;
        }
    }
}
