using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Hits;
using MucilageGame.Concretes.Controllers;
using MucilageGame.Concretes.Managers;
using MucilageGame.Concretes.UIs;
using UnityEngine;

namespace MucilageGame.Concretes.Hits
{
    public class CarCollide : IHit
    {
        private bool _isHit;
        public bool IsHit { get => _isHit; set => _isHit = value; }

        public void Collide(Collider other)
        {
            if (other.gameObject.CompareTag("Car") && other.gameObject != null)
            {
                GameManager.Instance.OnDie += HandleOnHitObstacle;
                GameManager.Instance.DieAction();
                _isHit = true;
            }
        }
        private void HandleOnHitObstacle()
        {
            GameManager.Instance.GameOverPanel.gameObject.SetActive(true);

            Time.timeScale = 0.0f;
        }
    }
}