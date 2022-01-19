using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MucilageGame.Abstracts.Movements
{
    public interface IMove
    {
        Vector3 Movement(float moveSpeed); //contract
    }
}