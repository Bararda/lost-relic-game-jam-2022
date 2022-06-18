using TMPro;
using UnityEngine;

namespace Tutorials
{
    public class BasicTutorialScript : MonoBehaviour
    {
        public TextMeshProUGUI movementText;
        public TextMeshProUGUI reconnectText;
        private BasicTutorialStage _currentStage;
    
        private enum BasicTutorialStage
        {
            Movement,
            Reconnect
        }
    
        private void Start()
        {
            _currentStage = BasicTutorialStage.Movement;
            reconnectText.enabled = false;
        }

        private void Update()
        {
            if (_currentStage != BasicTutorialStage.Movement) return;
        
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                _currentStage = BasicTutorialStage.Reconnect;
                movementText.enabled = false;
                reconnectText.enabled = true;
            }
        }
    }
}
