using UnityEngine;

namespace Matthew
{
    [CreateAssetMenu]
    public class Global : ScriptableObject
    {
        public static Global Instance
        {
            get
            {
                if (s_instance == null)
                    s_instance = Resources.Load<Global>("GlobalSingleton");
                return s_instance;
            }
        }

        private static Global s_instance;

        public void Print(string value)
        {
            Debug.Log(value);
        }
    }
}