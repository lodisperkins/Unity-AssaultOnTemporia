using System.Collections;
using System.Collections.Generic;
using Matthew;
using UnityEngine;

public class GameStateBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameEvent GameStartEvent;
	// Use this for initialization
	void Start ()
    {
		GameStartEvent.Raise();
	}
 
}
