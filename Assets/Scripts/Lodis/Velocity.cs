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
        public float timer;
        public float initial_time;
        public Vector3 updateVelocity(float dt, Vector3 direction)
        {
            var newtime = timer - dt;
            if (newtime <= 0) //if the newtime is less than 0 reset
                timer = initial_time;
            else
            {
                //otherwise take the new value
                timer = newtime;
                //calculate the new Vector
                float percent = timer / initial_time;
                value = Vector3.Lerp(value, Vector3.zero, percent);
            }
            return value;
        }
    }


    public static class Extensions
    {



    }
}
