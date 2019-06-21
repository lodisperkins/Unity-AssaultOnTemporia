using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textbehaviour : MonoBehaviour
{
    [SerializeField]
    private Intvariable value;
    [SerializeField]
    private string name;
    
    // Update is called once per frame
    void Update ()
    {
        GetComponent<Text>().text = name + " is:" +value.Val.ToString();
	}
}
