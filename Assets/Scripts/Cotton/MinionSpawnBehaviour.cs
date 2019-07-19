using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionSpawnBehaviour : MonoBehaviour
{
    MinionBehaviour Spawnpoint;
	// Use this for initialization
	void Start ()
    {
        Spawnpoint = GetComponent<MinionBehaviour>();
	}
	public void EnableSpawn()
    {
        Spawnpoint.enabled = true;
    }
    public void DisableSpawn()
    {
        foreach(GameObject enemy in Spawnpoint.Enemies)
        {
            Destroy(enemy);
        }
        Spawnpoint.enabled = false;
    }
	// Update is called once per frame
	void Update ()
    {
		
	}
}
