using UnityEngine;
using UnityEngine.SceneManagement;
namespace Interactables
{
    public class LevelGoalScript : MonoBehaviour
    {
        public LevelGoalScript linkedGoal;
        public bool isComplete = false;
        public string levelToLoad;
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                Debug.Log("Player entered the Goal");
                isComplete = true;
                CheckGoal();
            }
        }

        private void OnTriggerExit2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                Debug.Log("Player exited the Goal");
                isComplete = false;
            }
        }

        private void CheckGoal()
        {
            if (isComplete && linkedGoal.isComplete)
            {
                Debug.Log("Both goals are complete, Completed Level");
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }
}
