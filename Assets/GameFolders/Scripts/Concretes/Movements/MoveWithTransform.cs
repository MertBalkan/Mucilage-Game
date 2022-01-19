using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Controllers;
using MucilageGame.Abstracts.Movements;
using MucilageGame.Concretes.Controllers;
using UnityEngine;


namespace MucilageGame.Concretes.Movements
{
    public class MoveWithTransform : IMove
    {
        public Vector3 Movement(float moveSpeed)
        {
            return Vector3.back * Time.deltaTime * moveSpeed;
        }
    }
}