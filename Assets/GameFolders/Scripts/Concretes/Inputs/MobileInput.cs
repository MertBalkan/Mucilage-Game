using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Inputs;
using UnityEngine;

namespace MucilageGame.Concretes.Inputs
{
    public class MobileInput : IInput
    {
        public bool IsTouched => Input.GetMouseButton(0);
    }
}