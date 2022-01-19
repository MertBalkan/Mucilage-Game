using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MucilageGame.Concretes.ScriptableObjects
{
    [CreateAssetMenu(fileName = "PropData", menuName = "MucilageGame/PropData", order = 0)]
    public class PropSO : ScriptableObject
    {
        [SerializeField] private float _moveSpeed;
        public float MoveSpeed => _moveSpeed;
    }
}