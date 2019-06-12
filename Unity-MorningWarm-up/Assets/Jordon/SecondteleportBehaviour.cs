using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondteleportBehaviour : MonoBehaviour
{
    public Transform target = null;
    public Transform target2 = null;

    bool bjump = false;
    bool bjump2 = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Teleport" && bjump == false && bjump2 == false)
        {
            this.transform.position = target.position;
            bjump = true;
        }

        if(other.gameObject.tag == "Teleport2" && bjump == false && bjump2 == false)
        {
            this.transform.position = target2.position;
            bjump2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "teleport")
        {
            bjump2 = true;
        }

        if(other.gameObject.tag == "Teleport2")
        {
            bjump = true;
        }
    }

    void Update()
    {
        
    }

}
