using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.UIs;
using MucilageGame.Concretes.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace MucilageGame.Concretes.UIs
{
    public class FuelSlider : SliderUI
    {
        [SerializeField] private CarController _carController;
        public override bool Die => base.Die;

        private void Start()
        {
            SetSliderStartValue();
        }
        private void Update()
        {
            DecreaseSlider();
        }
        private void DecreaseSlider()
        {
            _slider.value -= (_carController.FuelDecreaseSpeed * Time.deltaTime);
        }
        private void SetSliderStartValue()
        {
            _slider.value = _carController.CurrentFuel;
        }
    }
}
