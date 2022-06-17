using Abstract;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
namespace Player
{
    public class Aspect : Subject
    {
        public Scrollbar scrollbar;
        public TMP_Text topText;
        public TMP_Text bottomText;
        public float value = 5;
        public int maxValue = 10;
        private Image _scrollbarImage;

        private void Awake()
        {
            _scrollbarImage = scrollbar.GetComponent<Image>();
        }

        public void SetSliderValue(float value)
        {
            float sliderValue = (value * 10);
            this.value = sliderValue;
            SetAspectText();
            NotifyObservers();
        }

        public void ChangeAspect(int amount)
        {
            Debug.Log("ChangeAspect" + amount + " " + value);
            value += amount;
            if (value < 0)
            {
                value = 0;
            }
            if (value > maxValue)
            {
                value = maxValue;
            }
            scrollbar.value = value / 10;
            SetAspectText();
            NotifyObservers();
        }

        public void SetAspectText()
        {
            topText.text = value.ToString();
            bottomText.text = (maxValue - value).ToString();
        }

        public void SetSelected(bool selected)
        {
            _scrollbarImage.color = selected ? new Color(.3747f, .9811f, .0138f) : new Color(.5742f, .58f, .58f);
        }
    }
}
