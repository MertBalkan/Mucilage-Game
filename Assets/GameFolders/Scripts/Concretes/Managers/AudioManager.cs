using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MucilageGame.Abstracts.Utilities;
using MucilageGame.Concretes.Auidos;

namespace MucilageGame.Concretes.Managers
{
    public class AudioManager : SingletonMonoBehaviour<AudioManager>
    {
        [SerializeField] private GameObject _carStartSound;
        [SerializeField] private GameObject _collectSound;
        [SerializeField] private GameObject _backgroundSound;

        private void Awake()
        {
            SingletonMethod(this);
        }
        private void Start()
        {
            PlayBackgroundMusic();
        }
        public void PlayEngineStartSound()
        {
            _carStartSound.GetComponent<AudioSource>().Play();
        }
        public void PlayCollectOilSound()
        {
            _collectSound.GetComponent<CollectAudio>().PlayRandomCollectOilClip();
        }
        public void PlayCollectSeaWasteSound()
        {
            _collectSound.GetComponent<CollectAudio>().PlayRandomCollectSeaWasteSound();
        }
        public void PlayBackgroundMusic()
        {
            _backgroundSound.GetComponent<AudioSource>().Play();
        }
    }
}