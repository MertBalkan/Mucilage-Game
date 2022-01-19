using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MucilageGame.Abstracts.Controllers
{
    public interface IEntityController
    {
        Transform transform { get; }
        float MoveSpeed { get; }
    }
}