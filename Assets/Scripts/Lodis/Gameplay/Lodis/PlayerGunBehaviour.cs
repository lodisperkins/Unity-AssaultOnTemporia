using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis.Gameplay
{
    public class PlayerGunBehaviour : MonoBehaviour
    {
        [SerializeField]
        private GameObject BulletEmitter;

        public void PullTrigger()
        {
            GunBehaviour Gun = BulletEmitter.GetComponent<GunBehaviour>();
            Gun.Player = tag;
            Gun.Fire();
        }
    }
}
