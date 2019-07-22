using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lodis.Gameplay
{
    public class PauseMenuBehaviour : MonoBehaviour
    {
        [SerializeField]
        private string PauseButton;
        [SerializeField]
        private GameObject image;
        bool isPaused;
        // Use this for initialization
        void Start()
        {
            isPaused = false;
            StartCoroutine("PauseInput");
        }

        public void Pause()
        {
            Time.timeScale = 0;
            image.SetActive(true);
        }

        bool togglePause()
        {
            if (Time.timeScale == 0f)
            {
                Time.timeScale = 1f;
                return (false);
            }
            else
            {
                Time.timeScale = 0f;
                return (true);
            }
        }

        public void UnPause()
        {
            Time.timeScale = 1;
            image.SetActive(false);
        }

        IEnumerator PauseInput()
        {
            while(true)
            {
                if (Input.GetButton(PauseButton))
                {
                    if (isPaused)
                    {
                        UnPause();
                    }
                    else
                    {
                        Pause();
                    }
                }
                yield return null;
            }
        }
        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
