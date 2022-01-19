using System.Collections;
using System.Collections.Generic;
using MucilageGame.Concretes.Controllers;
using MucilageGame.Concretes.Managers;
using UnityEngine;

namespace MucilageGame.Concretes.UIs
{
    public class JumpButtonUI : MonoBehaviour
    {
        [SerializeField] private CarController _carController;
        
        public void OnJumpButtonPressed()
        {
            _carController.JumpButtonPressed();
        }
    }
}