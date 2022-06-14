using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public class AspectManager : MonoBehaviour
    {
        public List<Aspect> aspects;
        private Aspect selectedAspect;

        void Start()
        {
            for (int i = 0; i < aspects.Count; i++)
            {
                aspects[i].SetSelected(false);
            }
            selectedAspect = aspects[0];
            selectedAspect.SetSelected(true);
        }
        void Update()
        {
            HandleKeyPress();
        }

        void HandleKeyPress()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                selectedAspect.ChangeAspect(-1);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                selectedAspect.ChangeAspect(1);
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                GetNextAspect(-1);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                GetNextAspect(1);
            }
        }

        void GetNextAspect(int amount)
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
