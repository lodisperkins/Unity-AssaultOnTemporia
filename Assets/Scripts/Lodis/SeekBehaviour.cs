using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lodis.Gameplay
{
    public class SeekBehaviour : MonoBehaviour {
        
    public VectorVariable target;
    [SerializeField]
    private Vector3 velocity;
    [SerializeField]
    private int max_speed;
        private Rigidbody body;
    // Use this for initialization
    void Start()
    {
            body = GetComponent<Rigidbody>();
    }
    void seek()
    {
        
        Vector3 seekforce = target.Val - transform.position;
        seekforce = (seekforce.normalized*max_speed) - velocity;
        if (velocity.magnitude > max_speed)
        {
            velocity=velocity.normalized*max_speed;
        }
            Debug.Log("Seekforce is " + seekforce);
            Debug.Log("Current Position is " + transform.position);
            Debug.Log("Target Position is " + target.Val);
            transform.position += seekforce*Time.deltaTime;
        }
    // Update is called once per frame
    void Update()
    {
        seek();
        transform.forward = target.Val; 
    }
}

}

