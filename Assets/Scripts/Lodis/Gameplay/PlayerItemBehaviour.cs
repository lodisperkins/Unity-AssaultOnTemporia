using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis
{
    public class PlayerItemBehaviour :MonoBehaviour
    {
        public GameObject Ball;
        public int DropDisplacement;
        public bool HasKey;
        [SerializeField]
        UnityEngine.Events.UnityEvent KeyDropped;
        // Use this for initialization
        void Start()
        {
            HasKey = false;
            
            
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Key"))
            {
                HasKey = true;
                KeyDropped.AddListener(other.GetComponent<KeyBehaviour>().CloseGates);
                Carry(other.gameObject);
            }
        }
        public void Carry(GameObject obj)
        {
            Ball = obj;
            PickUp(Ball);
        }
        public void PickUp(GameObject obj)
        {
            obj.GetComponent<MeshRenderer>().enabled = false;
            obj.GetComponent<SphereCollider>().enabled = false;
            obj.GetComponent<Transform>().SetParent(transform);
        }
        public void Drop()
        {
            if (HasKey)
            {
                var obj = Ball;
                KeyDropped.Invoke();
                obj.GetComponent<MeshRenderer>().enabled = true;
                obj.GetComponent<SphereCollider>().enabled = true;
                obj.GetComponent<Transform>().SetParent(null);
                obj.GetComponent<Transform>().position += new Vector3(DropDisplacement, 0, 0);
                HasKey = false;
            }
            else
            {
                return;
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
