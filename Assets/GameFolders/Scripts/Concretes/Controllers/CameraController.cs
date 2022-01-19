using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Controllers;
using MucilageGame.Concretes.Movements;
using UnityEngine;

namespace MucilageGame.Concretes.Controllers
{
    [RequireComponent(typeof(Camera))]

    public class CameraController : MonoBehaviour
    {
        [SerializeField] private LayerMask _layerMask;
        [SerializeField] private float duration = 1.0f;

        private Camera _camera;
        private Color startColor = Color.blue;
        private Color endColor = Color.green;
        private SkyboxController _skyboxController;
        
        public LayerMask LayerMask => _layerMask;

        public Camera Camera => _camera;

        private void Awake()
        {
            _camera = GetComponent<Camera>();

            _skyboxController = new SkyboxController(this);
        }

        private void Update()
        {
            _skyboxController.ControlSkybox(duration, startColor, endColor);
        }

    }
}