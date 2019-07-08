using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif  
using UnityEngine;

namespace Matthew
{


    [CreateAssetMenu]
    public class GameEvent : ScriptableObject, ISubscribeable
    {
        private List<IListener> listeners = new List<IListener>();

        public void RegisterListener(IListener listener)
        {
            listeners.Add(listener);
        }

        public void UnregisterListener(IListener listener)
        {
            listeners.Remove(listener);
        }

        public void Raise()
        {
            Raise(null);
        }

        public void AddListener(IListener listener)
        {
            RegisterListener(listener);
        }

        public void RemoveListener(IListener listener)
        {
            UnregisterListener(listener);
        }

        public void Raise(Object obj)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(obj);

            }
        }
    }

#if UNITY_EDITOR

    [CustomEditor(typeof(GameEvent))]
    public class GameEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("RaiseEvent"))
            {
                var mt = target as GameEvent;
                mt.Raise();
            }
        }
    }
#endif
}