using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lodis.Gameplay
{
    public class SeekBehaviour : MonoBehaviour {

    [SerializeField]
    private GameObject Target;
    [SerializeField]
    private Vector3 Velocity;
    [SerializeField]
    private int Max_Speed;
    void Seek()
    {
        
        Vector3 seekforce = Target.transform.position - transform.position;
        seekforce = (seekforce.normalized*Max_Speed) - Velocity;
        if (Velocity.magnitude > Max_Speed)
        {
            Velocity=Velocity.normalized*Max_Speed;
        }
        transform.position += seekforce*Time.deltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        Seek();
    }
}
}

