using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Player
{
    public class PlayerScript : MonoBehaviour
    {


        // Update is called once per frame
        void Update()
        {
            HandleKeyPress();
        }

        void HandleKeyPress()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Reset();
            }
        }

        public void Reset()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

