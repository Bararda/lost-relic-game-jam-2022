using TMPro;
using UnityEngine;

namespace Tutorials
{
    public class AspectTutorialScript : MonoBehaviour
    {
        public GameObject howToStatsText;
        public GameObject statReprecussionText;
        private AspectTutorialStage _currentStage;
    
        private enum AspectTutorialStage
        {
            HowTo,
            Reprecussions,
            Finish
        }
    
        private void Start()
        {
            _currentStage = AspectTutorialStage.HowTo;
            statReprecussionText.SetActive(false);
        }

        private void Update()
        {
            if (_currentStage == AspectTutorialStage.Finish)
            {
                return;
                
            } 
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                switch (_currentStage)
                {
                    case AspectTutorialStage.HowTo:
                        howToStatsText.SetActive(false);
                        statReprecussionText.SetActive(true);
                        _currentStage = AspectTutorialStage.Reprecussions;
                        break;
                    case AspectTutorialStage.Reprecussions:
                        statReprecussionText.SetActive(false);
                        _currentStage = AspectTutorialStage.Finish;
                        break;
                }
            }
        }
    }
}
