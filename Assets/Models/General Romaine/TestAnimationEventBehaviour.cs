using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimationEventBehaviour : MonoBehaviour
{
    //use a transform when you need to set position
    //use a gameobject reference when you need to instantiate
    public Transform Cherry;
 
    public void StartThrow()
    {
        
    }

    public void SetCherryState(int result)
    {
        
        
    }

    public void TurnOn()
    {
        Cherry.gameObject.SetActive(true);
    }

    public void TurnOff()
    {
        Cherry.gameObject.SetActive(false);
    }
 
}
