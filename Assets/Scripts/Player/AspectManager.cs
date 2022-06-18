using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public class AspectManager : MonoBehaviour
    {
        public List<Aspect> aspects;
        private Aspect selectedAspect;

        private void Start()
        {
            for (int i = 0; i < aspects.Count; i++)
            {
                aspects[i].SetSelected(false);
            }
            selectedAspect = aspects[0];
            selectedAspect.SetSelected(true);
        }

        private void Update()
        {
            HandleKeyPress();
        }

        private void HandleKeyPress()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                selectedAspect.ChangeAspect(1);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                selectedAspect.ChangeAspect(-1);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                GetNextAspect(-1);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                GetNextAspect(1);
            }
        }

        private void GetNextAspect(int amount)
        {
            selectedAspect.SetSelected(false);
            int index = aspects.IndexOf(selectedAspect);
            index += amount;
            if (index >= aspects.Count)
            {
                index = 0;
            }
            else if (index < 0)
            {
                index = aspects.Count - 1;
            }
            selectedAspect = aspects[index];
            selectedAspect.SetSelected(true);
        }
    }
}
