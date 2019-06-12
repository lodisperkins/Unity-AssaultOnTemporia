using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBehaviour : MonoBehaviour
{
    public GameObject ui;
    public GameObject objToTP;
    public Transform tpLOC;

    private void Start()
    {
        ui.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        ui.SetActive(true);

        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            objToTP.transform.position = tpLOC.transform.position;
        }
    }

    void OnTriggerExit(Collider other)
    {
        ui.SetActive(false);
    }
}
