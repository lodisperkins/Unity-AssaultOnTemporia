using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lodis
{
    [CreateAssetMenu(menuName = ("Variables/Integer"))]
    public class IntVariable : ScriptableObject
    {
        [SerializeField]
        int val;
        public int Val
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

