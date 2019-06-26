using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Lodis.Gameplay
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
            InitializeKey();
        }
        private void InitializeKey()
        {
            GateLocations = new List<Transform>();
            GateBehaviours = new List<GateBehaviour>();
            GateFuncs = new UnityEvent();

            foreach (GameObject obj in Gates)
            {
                GateLocations.Add(obj.transform);
                GateBehaviours.Add(obj.GetComponent<GateBehaviour>());
            }

        }
        private void OpenGates(GameObject player)
        {
            GateFuncs.RemoveAllListeners();
            for (int i = 0; i < GateLocations.Count; i++)
            {
                if (player.tag == "Player1")
                {
                    if (GateLocations[i].position.z < transform.position.z)
                    {
                        GateFuncs.AddListener(GateBehaviours[i].Open);
                        GateBehaviours[i].KeyHolder= player;
                    }
                }
                else if (player.tag == "Player2")
                {
                    if (GateLocations[i].position.z > transform.position.z)
                    {
                        GateFuncs.AddListener(GateBehaviours[i].Open);
                        GateBehaviours[i].KeyHolder = player;
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
                    if (GateLocations[i].position.z < transform.position.z)
                    {
                        GateFuncs.AddListener(GateBehaviours[i].Close);
                    }
                }
                else if (carrier == "Player2")
                {
                    if (GateLocations[i].position.z > transform.position.z)
                    {
                        GateFuncs.AddListener(GateBehaviours[i].Close);
                    }
                }
            }
            GateFuncs.Invoke();
        }
        public void Restart(Transform keyspawn)
        {
            CloseGates();
            InitializeKey();
            transform.position = keyspawn.position;
        }
        private void OnTriggerEnter(Collider other){
            OpenGates(other.gameObject);
            carrier = other.tag;
        }
        // Update is called once per frame
        void Update() {

        }
    }
}
