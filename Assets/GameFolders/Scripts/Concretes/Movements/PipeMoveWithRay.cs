using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Controllers;
using MucilageGame.Abstracts.Inputs;
using MucilageGame.Concretes.Controllers;
using UnityEngine;

namespace MucilageGame.Concretes.Movements
{
    public class PipeMoveWithRay : IRay
    {
        private IInput _input;
        private PipeController _pipe;
        private Vector3 _currentVelocity;

        public PipeMoveWithRay(IInput input, PipeController pipe, Vector3 currentVelocity)
        {
            _input = input;
            _pipe = pipe;
            _currentVelocity = currentVelocity;
        }
        public void ControlRay()
        {
            if (_input.IsTouched)
            {
                RaycastHit hit;
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, 60f) && CalculateBorders(hit))
                {
                    Vector3 smoothVec = Vector3.SmoothDamp(_pipe.transform.position, hit.point, ref _currentVelocity, 5f * Time.deltaTime);
                    Vector3 vec = new Vector3(smoothVec.x, _pipe.transform.position.y, smoothVec.z);
                    _pipe.transform.position = vec;
                }   
            }
        }

        private bool CalculateBorders(RaycastHit hit)
        {
            
            if (hit.point.x > -10.0f
            && hit.point.x < -1.0f
            && hit.point.z < 4.0f
            && hit.point.z > -8.0f)
                return true;

            return false;
        }
    }
}