using System.Collections;
using System.Collections.Generic;
using MucilageGame.Concretes.Managers;
using UnityEngine;

namespace MucilageGame.Concretes.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void PlayButtonPressed()
        {
            GameManager.Instance.PlayButtonPressed();
        }
    }
}