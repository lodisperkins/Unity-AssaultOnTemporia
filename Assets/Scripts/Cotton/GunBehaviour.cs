using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviour : MonoBehaviour
{
    public GameObject Bullet_Emitter;
    public GameObject Bullet;
    GameObject Temporary_Bullet_handler;
    public Lodis.VectorVariable Target;
    public float Bullet_Forward_Force;
    public float DespawnTime;
    public string Player;
    public bool canSeek;
    private void Start()
    {
        canSeek = false;
    }
    public void Fire()
    {
        Temporary_Bullet_handler = Instantiate(Bullet, transform.position, transform.rotation) as GameObject;
        Temporary_Bullet_handler.GetComponent<BulletBehaviour>().shooter = Player;
        Temporary_Bullet_handler.transform.Rotate(Vector3.right, 90);
        Rigidbody Temporary_rigidbody;
        Temporary_rigidbody = Temporary_Bullet_handler.GetComponent<Rigidbody>();
        if (canSeek)
        {
            Bullet.GetComponent<Lodis.Gameplay.SeekBehaviour>().enabled = true;
            Bullet.GetComponent<Lodis.Gameplay.SeekBehaviour>().target = Target;
            Destroy(Temporary_Bullet_handler, DespawnTime);
        }
        else
        {
            Bullet.GetComponent<Lodis.Gameplay.SeekBehaviour>().enabled = false;
            Temporary_rigidbody.AddForce(transform.forward * Bullet_Forward_Force);
            Destroy(Temporary_Bullet_handler, DespawnTime);
        }
    }
    // Update is called once per frame
    void Update ()
    {
      
	}
}
