using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Pools;
using MucilageGame.Concretes.Controllers;
using UnityEngine;

namespace MucilageGame.Concretes.Pools
{
    public class WaterPool : PoolMonoBehaviour
    {
        public override IEnumerator Spawn()
        {
            while (true)
            {
                var obj = GetPooledObject();
                obj.transform.position = this.transform.position;
                yield return new WaitForSeconds(SpawnData.SpawnRate * Time.deltaTime);
            }
        }
    }
}