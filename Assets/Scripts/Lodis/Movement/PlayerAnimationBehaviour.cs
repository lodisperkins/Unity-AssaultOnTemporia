using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis.Movement
{
    public class PlayerAnimationBehaviour : MonoBehaviour {
        Animator animator;
        [SerializeField]
        GameObject player;
        [SerializeField]
        VectorVariable velocity;
        // Use this for initialization
        void Start() {
            animator = GetComponent<Animator>();
        }
        public void Attack()
        {
            animator.SetTrigger("Attack");
        }
        public void GetHit()
        {
            animator.SetTrigger("GetHit");
        }
        public void Victory()
        {
            animator.SetTrigger("GameWon");
        }
        public void Throw()
        {
            player.GetComponent<Lodis.Gameplay.PlayerItemBehaviour>().Throw();
        }
        // Update is called once per frame
        void Update() {
            animator.SetFloat("Speed",velocity.Val.magnitude);
        }
    }
}
