using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTestScript : MonoBehaviour {
    [Range(0,1)]
    public float t;
    public Vector3 startvec;
    public Vector3 endvec;
    public Vector3 result;
	// Update is called once per frame
	void Update () {

        result = Vector3.Lerp(startvec, endvec, t);
	}
}
