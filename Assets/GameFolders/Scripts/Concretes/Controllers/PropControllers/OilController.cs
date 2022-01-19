using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Controllers;
using UnityEngine;

namespace MucilageGame.Concretes.Controllers
{
    public class OilController : PropController<OilController>
    {
        protected void Update()
        {
            base.Update();
            transform.Translate(Vector3.up * Mathf.Sin(Time.time * 8) * Time.deltaTime);
        }
    }
}