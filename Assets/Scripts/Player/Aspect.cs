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
        public Image selectedImage;
        public float value = 5;
        public int maxValue = 10;
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
            selectedImage.enabled = selected;
        }
    }
}
