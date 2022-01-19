using System.Collections;
using System.Collections.Generic;
using Concretes.Prototypes;
using MucilageGame.Abstracts.Hits;
using MucilageGame.Abstracts.Pools;
using MucilageGame.Concretes.Controllers;
using MucilageGame.Concretes.Managers;
using MucilageGame.Concretes.Pools;
using MucilageGame.Concretes.UIs;
using UnityEngine;

namespace MucilageGame.Concretes.Hits
{
    public class PipeCollide : IHit
    {
        private MucilagePool[] _mucilagePools;
        private OilPool[] _oilPools;
        private SeaWastePool[] _seaWastes;
        private FuelSlider _fuelSlider;
        private StuckSlider _stuckSlider;
        private SeaFadePrototype _seaFadeScript;

        public PipeCollide(MucilagePool[] mucilagePools, OilPool[] oilPools, SeaWastePool[] seaWastes, FuelSlider fuelSlider, StuckSlider stuckSlider)
        {
            _mucilagePools = mucilagePools;
            _oilPools = oilPools;
            _seaWastes = seaWastes;
            _fuelSlider = fuelSlider;
            _stuckSlider = stuckSlider;
        }

        public void Collide(Collider other)
        {
            if (other != null)
            {

                if (other.gameObject.tag.Equals("Oil"))
                {
                    _fuelSlider.SliderValue += 5;

                    foreach (var oilPool in _oilPools)
                        oilPool.DisableObjectFromQueue(other);
                    AudioManager.Instance.PlayCollectOilSound();

                }

                if (other.gameObject.tag.Equals("SeaWaste"))
                {
                    _stuckSlider.SliderValue++;

                    foreach (var seaWastePool in _seaWastes)
                        seaWastePool.DisableObjectFromQueue(other);

                    AudioManager.Instance.PlayCollectSeaWasteSound();

                }
            }
        }
    }
}