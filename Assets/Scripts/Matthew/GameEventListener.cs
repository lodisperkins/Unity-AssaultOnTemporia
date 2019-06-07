using UnityEngine;

namespace Matthew
{
    public class GameEventListener : MonoBehaviour, IListener
    {
        public GameEvent GameEvent;
        public GameEventResponse Response;

        void OnEnable()
        {
            Subscribe();
        }
        public void Subscribe()
        {
            GameEvent.AddListener(this);
        }

        public void Unsubscribe()
        {
            GameEvent.RemoveListener(this);
        }

        public void OnEventRaised(Object obj)
        {
            Response.Invoke(obj);
        }

        public void OnEventRaised()
        {
            OnEventRaised(null);
        }

        void OnDisable()
        {
            Unsubscribe();
        }
    }
}
 