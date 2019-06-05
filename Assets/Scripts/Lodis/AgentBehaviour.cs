using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentBehaviour : MonoBehaviour {
    private Vector3 playerInput;
    [SerializeField]
    private string horizontalAxis;
    [SerializeField]
    private string verticalAxis;

	// Update is called once per frame
	void Update () {
        playerInput = new Vector3(Input.GetAxis(horizontalAxis), 0, Input.GetAxis(verticalAxis));
        GetComponent<NavMeshAgent>().destination = transform.position + playerInput;
	}
}
