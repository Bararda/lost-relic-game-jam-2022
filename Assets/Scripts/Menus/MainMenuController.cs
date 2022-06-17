using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menus
{
    public class MainMenuController : MonoBehaviour
    {
        public void Play()
        {
            SceneManager.LoadScene("Vertical Level");
        }

        public void GoToCredits()
        {
            SceneManager.LoadScene("Credits");
        }

        public void GoToMainMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }

        public void LinkToBillbobphilItchPage()
        {
            Application.OpenURL("https://billbobphil.itch.io/");
        }
        
        public void LinkToBarardaItchPage()
        {
            Application.OpenURL("https://bararda.itch.io/");
        }
    }
}
