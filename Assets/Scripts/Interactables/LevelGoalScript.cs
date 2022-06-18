using UnityEngine;
using UnityEngine.SceneManagement;
using Player;
namespace Interactables
{
    public class LevelGoalScript : MonoBehaviour
    {
        public LevelGoalScript linkedGoal;
        public bool isComplete = false;
        public string levelToLoad;

        public GameObject levelEndScreen;

        void Update()
        {
            if (levelEndScreen.activeSelf)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SceneManager.LoadScene(levelToLoad);
                }
            }
        }
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                isComplete = true;
                CheckGoal();
            }
        }

        private void OnTriggerExit2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                isComplete = false;
            }
        }

        private void CheckGoal()
        {
            if (isComplete && linkedGoal.isComplete)
            {
                // get and deactivate the movement
                Movement[] movementObjects = FindObjectsOfType<Movement>();
                foreach (Movement movement in movementObjects)
                {
                    movement.enabled = false;
                }
                levelEndScreen.SetActive(true);
            }
        }
    }
}
