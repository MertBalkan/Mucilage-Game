using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Controllers;
using MucilageGame.Abstracts.Inputs;
using MucilageGame.Concretes.Inputs;
using MucilageGame.Concretes.Movements;
using UnityEngine;
using UnityEngine.UI;

namespace MucilageGame.Concretes.Controllers
{
    public class PipeController : MonoBehaviour
    {
        private Vector3 _currentVelocity = Vector3.zero;
        private IInput _input;        
        private Animator _animator;
        private IRay _ray;

        private void Awake()
        {
            _input = new MobileInput();
            _animator = GetComponent<Animator>();
            _ray = new PipeMoveWithRay(_input, this, _currentVelocity);
        }

        private void Update()
        {
            _ray.ControlRay();
        }
    }
}