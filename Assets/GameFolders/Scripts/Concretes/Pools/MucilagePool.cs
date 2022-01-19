using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Movements;
using MucilageGame.Abstracts.Pools;
using MucilageGame.Concretes.Controllers;
using MucilageGame.Concretes.Movements;
using UnityEngine;

namespace MucilageGame.Concretes.Pools
{
    public class MucilagePool : PoolMonoBehaviour
    {
        private IMove _move;

        protected override void Awake()
        {
            base.Awake();
            _move = new PoolMove();
        }

        protected override void Update()
        {
            this.transform.position += _move.Movement(5.0f) * Time.deltaTime;
        }
        public override IEnumerator Spawn()
        {
            while (true)
            {
                var obj = GetPooledObject();
                obj.transform.position = this.transform.position;
                yield return new WaitForSeconds(SpawnData.SpawnRate);
            }
        }
    }
}