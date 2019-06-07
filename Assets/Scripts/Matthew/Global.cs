using UnityEngine;

namespace Matthew
{
    [CreateAssetMenu]
    public class Global : ScriptableObject
    {
        public string Tag;
        public static Global Instance
        {
            get
            {
                if (s_instance == null)
                    s_instance = Resources.Load<Global>("GlobalSingleton");
                return s_instance;
            }
        }

        public void SpawnPrefab(GameObject prefab)
        {
            Instantiate(prefab);
        }
        public void TeleportPlayer1To(Transform transform)
        {
            var player = GameObject.FindGameObjectWithTag("Player1");
            player.transform.position = transform.position;
        }
        public void TeleportPlayer2To(Transform transform)
        {
            var player = GameObject.FindGameObjectWithTag("Player2");
            player.transform.position = transform.position;
        }
        public void TeleportPlayerTo(Transform transform)
        {
            var player = GameObject.FindGameObjectWithTag(Tag);
            player.transform.position = transform.position;
        }
        private static Global s_instance;

        public void Print(string value)
        {
            Debug.Log(value);
        }
    }
}