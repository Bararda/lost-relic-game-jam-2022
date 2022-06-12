using Abstract;
using TMPro;
using UnityEngine.UI;

namespace Player
{
    public class Aspect : Subject
    {
        public Scrollbar scrollbar;
        public TMP_Text topText;
        public TMP_Text bottomText;
        public int value = 5;
        public int maxValue = 10;

        public void SetSliderValue(float value)
        {
            int sliderValue = (int)(value * 10);
            topText.text = sliderValue.ToString();
            bottomText.text = (10 - sliderValue).ToString();
            this.value = sliderValue;
            NotifyObservers();
        }
    }
}
