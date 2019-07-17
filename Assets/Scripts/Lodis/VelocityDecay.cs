using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis
{
    [System.Serializable]
    public class VelocityDecay
    {
        public Vector3 Value;
        public Vector3 Initial_Value;
        [Range(1,0)]
        float percent;
        public float Timer;
        public float Initial_Time;
        public VelocityDecay(float time, Vector3 direction)
        {
            Initial_Time = time;
            Value = direction;
        }
        public Vector3 UpdateVelocity(float dt)
        {
            var newtime = Timer + dt;
            if (newtime >= 1) //if the newtime is less than 0 reset
                Timer = 0;
            else
            {
                //otherwise take the new value
                Timer = newtime;
                //calculate the new Vector
                percent = Timer / Initial_Time;
                Value = Vector3.Lerp(Value, Vector3.zero, percent);
            }
            return Value;
        }
    }
}
