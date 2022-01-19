using System.Collections;
using System.Collections.Generic;
using MucilageGame.Concretes.Managers;
using UnityEngine;

namespace MucilageGame.Concretes.Auidos
{
    public class CollectAudio : MonoBehaviour
    {
        [SerializeField] private List<AudioClip> _oilColletAudios;
        [SerializeField] private List<AudioClip> _seaWasteStuckAudios;
        private AudioSource _audioSource;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        public void PlayRandomCollectOilClip()
        {
            _audioSource.PlayOneShot(_oilColletAudios[Random.Range(0, _oilColletAudios.Capacity)]);
        }
        public void PlayRandomCollectSeaWasteSound()
        {
            _audioSource.PlayOneShot(_seaWasteStuckAudios[Random.Range(0, _seaWasteStuckAudios.Capacity)]);
        }
    }
}