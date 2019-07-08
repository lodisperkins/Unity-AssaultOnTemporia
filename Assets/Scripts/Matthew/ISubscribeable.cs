using UnityEngine;

namespace Matthew
{
    public interface ISubscribeable
    {
        void AddListener(IListener listener);
        void RemoveListener(IListener listener);
        void Raise(Object obj);
        void Raise();
    }
}