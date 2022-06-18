using TMPro;
using UnityEngine;

namespace Tutorials
{
    public class AspectTutorialScript : MonoBehaviour
    {
        public TextMeshProUGUI howToStatsText;
        public TextMeshProUGUI statReprecussionText;
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
            statReprecussionText.enabled = false;
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
                        howToStatsText.enabled = false;
                        statReprecussionText.enabled = true;
                        _currentStage = AspectTutorialStage.Reprecussions;
                        break;
                    case AspectTutorialStage.Reprecussions:
                        statReprecussionText.enabled = false;
                        _currentStage = AspectTutorialStage.Finish;
                        break;
                }
            }
        }
    }
}
