using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Variable/Int"))]
public class Intvariable : ScriptableObject
{
    [SerializeField]
    private int _val;

    public int Val
    {
        get
        {
            return _val;
        }
        set
        {
            _val = value;
        }
    }
}
