using UnityEngine;
using TMPro;
using MucilageGame.Concretes.Controllers;
using MucilageGame.Concretes.Managers;

namespace MusilageGame.Concretes.UIs
{
    public class NumberTextUI : MonoBehaviour
    {
        private TMP_Text _text;
        private CollectorController _collectorController;

        private void Awake()
        {
            //Return Null But Why? Solve it.
            _collectorController = GameObject.FindObjectOfType<CollectorController>();
            _text = GetComponent<TMP_Text>();
        }

        private void Update()
        {
            _text.text = _collectorController.CollectedMucilages.ToString();
        }
    }
}