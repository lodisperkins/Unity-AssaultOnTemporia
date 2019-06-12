using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public GameObject Bullet_Emitter;
    public GameObject Bullet;

    public float Bullet_Forward_Force;

	// Update is called once per frame
	void Update ()
    {
            GameObject Temporary_Bullet_handler;
            Temporary_Bullet_handler = Instantiate(Bullet, transform.position, transform.rotation) as GameObject;
           
            

            Rigidbody Temporary_rigidbody;
            Temporary_rigidbody = Temporary_Bullet_handler.GetComponent<Rigidbody>();

            Temporary_rigidbody.AddForce(transform.up * Bullet_Forward_Force);
            Destroy(Temporary_Bullet_handler, 10.0f);
            Bullet_Emitter.transform.Rotate(Vector3.forward * 90);
        
	}
}
