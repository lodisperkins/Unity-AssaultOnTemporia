using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Lodis
{
    public class KeyBehaviour : MonoBehaviour {
        [SerializeField]
        private List<GameObject> Gates;
        private List<Transform> GateLocations;
        private List<GateBehaviour> GateBehaviours;
        private string carrier;
        UnityEvent GateFuncs;
        [SerializeField]
        UnityEvent OnTriggerEnterResponse;
        // Use this for initialization
        void Start() {
            GateLocations = new List<Transform>();
            GateBehaviours = new List<GateBehaviour>();
            GateFuncs = new UnityEvent();
            
            foreach (GameObject obj in Gates)
            {
                GateLocations.Add(obj.transform);
                GateBehaviours.Add(obj.GetComponent<GateBehaviour>());
            }
            
        }
        private void OpenGates(string player)
        {
            GateFuncs.RemoveAllListeners();
            for (int i = 0; i < GateLocations.Count; i++)
            {
                if (player == "Player1")
                {
                    if (GateLocations[i].position.x > transform.position.x)
                    {
                        GateFuncs.AddListener(GateBehaviours[i].Open);
                        GateBehaviours[i].compareTag = player;
                    }
                }
                else if (player == "Player2")
                {
                    if (GateLocations[i].position.x < transform.position.x)
                    {
                        GateFuncs.AddListener(GateBehaviours[i].Open);
                        GateBehaviours[i].compareTag = player;
                    }
                }
            }
            GateFuncs.Invoke();
        }
        public void CloseGates()
        {
            GateFuncs.RemoveAllListeners();
            for (int i = 0; i < GateLocations.Count; i++)
            {
                if (carrier == "Player1")
                {
                    if (GateLocations[i].position.x > transform.position.x)
                    {
                        GateFuncs.AddListener(GateBehaviours[i].Close);
                        GateBehaviours[i].compareTag = carrier;
                    }
                }
                else if (carrier == "Player2")
                {
                    if (GateLocations[i].position.x < transform.position.x)
                    {
                        GateFuncs.AddListener(GateBehaviours[i].Close);
                        GateBehaviours[i].compareTag = carrier;
                    }
                }
            }
            GateFuncs.Invoke();
        }
        private void OnTriggerEnter(Collider other){
            OpenGates(other.tag);
            carrier = other.tag;
        }
        // Update is called once per frame
        void Update() {

        }
    }
}
