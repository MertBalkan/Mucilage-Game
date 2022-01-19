using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Movements;
using MucilageGame.Concretes.Movements;
using MucilageGame.Concretes.ScriptableObjects;
using UnityEngine;

namespace MucilageGame.Abstracts.Controllers
{
    public abstract class PropController<T> : MonoBehaviour, IEntityController where T : Component
    {
        [SerializeField] private PropSO _propData;
        private IMove _move;

        //MAKE HERE DYNAMIC LATER...
        public float MoveSpeed => _propData.MoveSpeed;
        protected void Awake()
        {
            _move = new MoveWithTransform();
        }

        protected virtual void Update()
        {
            this.transform.position += _move.Movement(this.MoveSpeed) * Time.deltaTime;
        }
    }
}