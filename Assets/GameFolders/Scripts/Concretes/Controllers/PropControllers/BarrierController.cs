using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Controllers;
using MucilageGame.Concretes.Enums;
using MucilageGame.Concretes.Managers;
using UnityEngine;

namespace MucilageGame.Concretes.Controllers
{
    public class BarrierController : PropController<BarrierController>
    {
        [SerializeField] private BarrierEnum _barrierEnum;

        protected override void Update()
        {
            base.Update();
            if (_barrierEnum == BarrierEnum.Default)
            {
                Destroy(this.gameObject, 10.0f);
            }
        }
    }
}