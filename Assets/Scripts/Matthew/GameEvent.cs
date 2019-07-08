
using System.Collections.Generic;
using UnityEngine;

namespace Matthew
{
    [CreateAssetMenu(menuName = "GameEvents/GameEvent")]
    public class GameEvent : ScriptableObject, ISubscribeable
    {
        public List<IListener> Listeners = new List<IListener>();

        public void Raise(Object obj)
        {
            for (var i = Listeners.Count - 1; i >= 0; i--)
                Listeners[i].OnEventRaised(obj);
        }
        public void Raise()
        {
            Raise(null);
        }
        public void AddListener(IListener listener)
        {
            Listeners.Add(listener);
        }

        public void RemoveListener(IListener listener)
        {
            Listeners.Remove(listener);
        }
    }
}