using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Inputs;
using UnityEngine;

namespace MucilageGame.Concretes.Inputs
{
    public class PCInput : IInput
    {
        public bool IsTouched => Input.GetKeyDown(KeyCode.Space);
    }
}