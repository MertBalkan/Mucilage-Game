using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Movements;
using MucilageGame.Abstracts.Pools;
using MucilageGame.Concretes.Pools;
using UnityEngine;

namespace MucilageGame.Concretes.Movements
{
    public class PoolMove : IMove
    {
        public Vector3 Movement(float moveSpeed)
        {
            //_pool.transform.position = new Vector3(Mathf.PingPong(Time.time, 5) - 8.5f, _pool.transform.position.y, _pool.transform.position.z) * moveSpeed;
            return new Vector3((2.0f * Mathf.PingPong(Time.time, 1.0f) - 1.0f) * moveSpeed, 0, 0);
        }
    }
}