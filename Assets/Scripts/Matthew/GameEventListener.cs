using UnityEngine;

namespace Matthew
{
    public class GameEventListener : MonoBehaviour, IListener
    {
        public GameEvent GameEvent;
        public GameEventResponse Response;
        public GameObject SenderObject;
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
            if(SenderObject != null && SenderObject == obj)

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
 