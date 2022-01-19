using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Hits;
using MucilageGame.Abstracts.Inputs;
using MucilageGame.Concretes.Hits;
using MucilageGame.Concretes.Inputs;
using MucilageGame.Concretes.UIs;
using UnityEngine;

namespace MucilageGame.Concretes.Controllers
{
    public class CarController : MonoBehaviour
    {
        [SerializeField] private float _currentFuel = 100.0f;
        [SerializeField] private float _fuelDecreaseSpeed = 3.0f;
        private Animator _anim;
        public float FuelDecreaseSpeed => _fuelDecreaseSpeed;
        public float CurrentFuel { get => _currentFuel; set => _currentFuel = value; }
        private IInput _input;

        private void Awake()
        {
            _anim = GetComponent<Animator>();
            _input = new PCInput();
        }
        private void Update()
        {
            if (_input.IsTouched)
                JumpButtonPressed();
        }
        public void JumpButtonPressed()
        {
            _anim.SetTrigger("isJump");
        }
    }
}