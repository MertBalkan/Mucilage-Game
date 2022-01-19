using System;
using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Utilities;
using MucilageGame.Concretes.UIs;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MucilageGame.Concretes.Managers
{
    public class GameManager : SingletonMonoBehaviour<GameManager>
    {
        [SerializeField] private GameOverPanel _gameOverPanel;
        private float _passedTime;
        public GameOverPanel GameOverPanel => _gameOverPanel;

        public event System.Action OnMucilageCollected;
        public event System.Action OnDie;

        private void Awake()
        {
            Time.timeScale = 0.0f;
            SingletonMethod(this);
        }
        private void Update()
        {
            _passedTime += Time.deltaTime;

        }
        public void Collect()
        {
            OnMucilageCollected?.Invoke();
        }

        public void DieAction()
        {
            OnDie?.Invoke();
        }
        
        public void PlayButtonPressed()
        {
            Time.timeScale = 1.0f;
        }
        public void ReLoadGameScene()
        {
            StartCoroutine(ReLoadGameSceneAsync());
        }
        private IEnumerator ReLoadGameSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync(0);
        }
    }
}