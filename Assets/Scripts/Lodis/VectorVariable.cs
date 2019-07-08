using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis
{
    [CreateAssetMenu(menuName =("Variables/Vector3"))]
    public class VectorVariable : ScriptableObject {

        Vector3 val;
        public Vector3 Val
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
            }
        }

    }
}

