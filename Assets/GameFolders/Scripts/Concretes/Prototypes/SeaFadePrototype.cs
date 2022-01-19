using System.Collections;
using System.Collections.Generic;
using MucilageGame.Concretes.Controllers;
using MucilageGame.Concretes.Hits;
using MucilageGame.Concretes.Pools;
using UnityEngine;

namespace Concretes.Prototypes
{
    public class SeaFadePrototype : MonoBehaviour
    {
        //Access the current part of the sea and then;
        //Access the mesh renderer of that object and then;
        // Access the mesh renderer's material
        //Time by time slowly change the fade of that material
        //Final time make that material to blue
        private MeshRenderer _currentSeaMeshRenderer;

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "LastObject")
            {
                ChangeColorByTime(this.GetComponent<WaterController>());
            }
        }

        public void ChangeColorByTime(WaterController seaObject)
        {
            if (seaObject == null) return;
            _currentSeaMeshRenderer = seaObject.gameObject.GetComponent<MeshRenderer>();
            var myColor = _currentSeaMeshRenderer.material.color;
            myColor = Color.Lerp(myColor, Color.blue, Time.time * 0.1f * Time.deltaTime);

            _currentSeaMeshRenderer.material.SetColor("_Color", myColor);
        }
    }
}
