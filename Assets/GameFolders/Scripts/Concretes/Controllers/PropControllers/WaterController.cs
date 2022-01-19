using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Controllers;
using MucilageGame.Concretes.Enums;
using UnityEngine;

namespace MucilageGame.Concretes.Controllers
{
    public class WaterController : PropController<WaterController>
    {
        [SerializeField] private WaterEnum _waterEnum;

        protected override void Update() 
        {
            base.Update();
            if(_waterEnum == WaterEnum.Spawned)
            { 
                Destroy(this.gameObject, 30f);
            }    
        }
    }
}