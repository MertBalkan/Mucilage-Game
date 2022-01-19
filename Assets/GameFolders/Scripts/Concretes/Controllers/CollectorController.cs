using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Hits;
using MucilageGame.Concretes.Hits;
using MucilageGame.Concretes.Managers;
using MucilageGame.Concretes.Pools;
using MucilageGame.Concretes.UIs;
using UnityEngine;

//Vs code eklentisi -> shift + ctrl + . fonksiyonları gösteriyor.

namespace MucilageGame.Concretes.Controllers
{
    public class CollectorController : MonoBehaviour
    {
        private MucilagePool[] _mucilagePools;
        private OilPool[] _oilPools;
        private SeaWastePool[] _seaWastes;
        private FuelSlider _fuelSlider;
        private StuckSlider _stuckSlider;
        private IHit _collideObjects;
        private float _collectedMucilages;
        public float CollectedMucilages => _collectedMucilages;

        private void Awake()
        {
            _mucilagePools = FindObjectsOfType<MucilagePool>();
            _oilPools = FindObjectsOfType<OilPool>();
            _seaWastes = FindObjectsOfType<SeaWastePool>();
            _fuelSlider = FindObjectOfType<FuelSlider>();
            _stuckSlider = FindObjectOfType<StuckSlider>();

            _collideObjects = new PipeCollide(_mucilagePools, _oilPools, _seaWastes,_fuelSlider, _stuckSlider);
        }
        private void Update()
        {
            GameManager.Instance.Collect();
            transform.position = GameObject.FindGameObjectWithTag("LastObject").transform.position;
        }

        private void Start()
        {
            GameManager.Instance.OnMucilageCollected += HandleOnMucilageCollected;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMucilageCollected -= HandleOnMucilageCollected;
        }

        private void HandleOnMucilageCollected()
        {
            //FIND SOLUTION HERE LATER...
            _collectedMucilages += (float)System.Math.Round((double)Time.deltaTime, 5);
        }
        private void OnTriggerEnter(Collider other)
        {
            _collideObjects.Collide(other);
        }
    }
}