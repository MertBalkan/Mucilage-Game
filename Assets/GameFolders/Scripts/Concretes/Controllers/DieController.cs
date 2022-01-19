using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Hits;
using MucilageGame.Concretes.Hits;
using MucilageGame.Concretes.Managers;
using MucilageGame.Concretes.UIs;
using UnityEngine;

namespace MucilageGame.Concretes.Controllers
{
    public class DieController : MonoBehaviour
    {
        [SerializeField] private FuelSlider _fuelSlider;
        [SerializeField] private StuckSlider _stuckSlider;

        private void Start()
        {
            // GameManager.Instance.OnDie += HandleOnHitObstacle;
            GameManager.Instance.OnDie += HandleOnFuelEnd;
            GameManager.Instance.OnDie += HandleOnStuckCapacity;
        }
        private void Update()
        {
            GameManager.Instance.DieAction();
        }
        private void OnDisable()
        {
            GameManager.Instance.OnDie -= HandleOnFuelEnd;
            GameManager.Instance.OnDie -= HandleOnStuckCapacity;
            // GameManager.Instance.OnDie -= HandleOnHitObstacle;
        }
        private void HandleOnFuelEnd()
        {
            if (_fuelSlider.Die)
            {
                GameManager.Instance.GameOverPanel.gameObject.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
        private void HandleOnStuckCapacity()
        {
            if (_stuckSlider.Die)
            {
                GameManager.Instance.GameOverPanel.gameObject.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
        //Burası ile sonra ilgilenilecek
        //HandleOnHitObstacle buraya taşınacak
        //HandleOnHitObstacle fonksiyonu içinde eğer bariyere çarptıysa oyun bitmeli kontrolü yapılacak
        //O fonksiyon şu anda CarCollidenin içinde...
    }
}