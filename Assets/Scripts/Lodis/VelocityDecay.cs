using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis
{
    [System.Serializable]
    public class VelocityDecay
    {

        public Vector3 value;
        public Vector3 initial_value;
        [Range(1,0)]
        float percent;
        public float timer;
        public float initial_time;
        public VelocityDecay(float time, Vector3 direction)
        {
            initial_time = time;
            value = direction;
        }
        public Vector3 updateVelocity(float dt)
        {
            var newtime = timer + dt;
            if (newtime >= 1) //if the newtime is less than 0 reset
                timer = 0;
            else
            {
                //otherwise take the new value
                timer = newtime;
                //calculate the new Vector
                percent = timer / initial_time;
                value = Vector3.Lerp(value, Vector3.zero, percent);
            }
            return value;
        }
    }
}
