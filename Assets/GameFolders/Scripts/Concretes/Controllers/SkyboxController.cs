using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MucilageGame.Concretes.Controllers
{
    public class SkyboxController
    {
        private CameraController _cameraController;

        public SkyboxController(CameraController cameraController)
        {
            _cameraController = cameraController;
        }

        public void ControlSkybox(float duration, Color startColor, Color endColor)
        {
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            _cameraController.Camera.backgroundColor = Color.Lerp(startColor, endColor, lerp);
        }

    }
}