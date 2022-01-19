using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MucilageGame.Abstracts.UIs
{
    public class SliderUI : MonoBehaviour
    {
        protected Slider _slider;
        public float SliderValue { get { return _slider.value; } set { _slider.value = value; } }
        public virtual bool Die => _slider.value <= 0; 
        
        private void Awake()
        {
            _slider = GetComponent<Slider>();
        }
    }
}