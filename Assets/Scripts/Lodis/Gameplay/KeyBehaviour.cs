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
        private string Carrier;
        private UnityEvent GateFuncs;
        [SerializeField]
        private GameObject Tracker;
        [SerializeField]
        private UnityEvent OnTriggerEnterResponse;
        [SerializeField]
        public int dropval;
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
                if (Carrier == "Player1")
                {
                    if (GateLocations[i].position.z < transform.position.z)
                    {
                        GateFuncs.AddListener(GateBehaviours[i].Close);
                    }
                }
                else if (Carrier == "Player2")
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
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<SphereCollider>().isTrigger = true;
            Destroy(GetComponent<Rigidbody>());
            transform.rotation = new Quaternion(0, 0, 0, 0);
            Tracker.SetActive(true);
            CloseGates();
            InitializeKey();
            transform.position = keyspawn.position;
            
        }
        public void DisableKey()
        {
            GetComponent<MeshRenderer>().enabled = false;
            Tracker.SetActive(false);
        }

        private void OnTriggerEnter(Collider other){
            if (other.CompareTag("Goal"))
            {
                DisableKey();
            }
            else if (other.CompareTag("Player1") || other.CompareTag("Player2"))
            {
                OpenGates(other.gameObject);
                Carrier = other.tag;
            }
            else
            {
                transform.position += new Vector3(0,0,dropval);
            }
        }
    }
}
