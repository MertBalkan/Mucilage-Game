using System;
using System.Collections;
using System.Collections.Generic;
using MucilageGame.Concretes.Managers;
using UnityEngine;

namespace MucilageGame.Concretes.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        private void Start()
        {
            this.gameObject.SetActive(false);
        }

        public void ReplayGame()
        {
            GameManager.Instance.ReLoadGameScene();
            GameManager.Instance.PlayButtonPressed();
        }
    }
}