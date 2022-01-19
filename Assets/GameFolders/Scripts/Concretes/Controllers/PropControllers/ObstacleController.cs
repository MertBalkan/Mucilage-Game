using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Controllers;
using MucilageGame.Abstracts.Hits;
using MucilageGame.Concretes.Hits;
using UnityEngine;

namespace MucilageGame.Concretes.Controllers
{
    public class ObstacleController : PropController<ObstacleController>
    {
        private IHit _collideDetection;

        private void Start()
        {
            _collideDetection = new CarCollide();
        }
        private void OnTriggerEnter(Collider other)
        {
            _collideDetection.Collide(other);
        }
    }
}