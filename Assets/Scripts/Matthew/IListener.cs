using UnityEngine;

namespace Matthew
{
    public interface IListener
    {
        void Subscribe();
        void Unsubscribe();
        void OnEventRaised(Object obj);
        void OnEventRaised();
    }
}