using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.UIs;
using UnityEngine;
using UnityEngine.UI;

namespace MucilageGame.Concretes.UIs
{
    public class StuckSlider : SliderUI
    {
        public override bool Die => _slider.value >= 5;
    }
}