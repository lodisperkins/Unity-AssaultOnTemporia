using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class MinionSpawnBehaviour : MonoBehaviour
{
    MinionBehaviour Spawnpoint;
    
    [SerializeField]
    private CinemachineVirtualCamera Camera;
    // Use this for initialization
    void Start ()
    {
        Spawnpoint = GetComponent<MinionBehaviour>();
	}
	public void EnableSpawn()
    {
        Spawnpoint = GetComponent<MinionBehaviour>();
        Spawnpoint.enabled = true;
    }
    public void DisableSpawn()
    {
        if(Spawnpoint == null)
        {
            return;
        }
        foreach(GameObject enemy in Spawnpoint.Enemies)
        {
            Destroy(enemy);
        }
        Spawnpoint.StopAllCoroutines();
        Spawnpoint.enabled = false;
    }
	// Update is called once per frame
	void Update ()
    {
		if(Camera.enabled)
        {
            EnableSpawn();
            return;
        }
        DisableSpawn();
	}
}
