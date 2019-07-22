using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public string shooter;
    private void OnCollisionEnter(Collision collision)
    {
        var temp = gameObject;
        Destroy(temp);
    }
    private void OnTriggerEnter(Collider other)
    {
        var temp = gameObject;
        Destroy(temp);
    }
}
