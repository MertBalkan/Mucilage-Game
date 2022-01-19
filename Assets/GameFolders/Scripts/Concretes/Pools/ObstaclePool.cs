using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Pools;
using MucilageGame.Concretes.Controllers;
using UnityEngine;

namespace MucilageGame.Concretes.Pools
{
    public class ObstaclePool : PoolMonoBehaviour
    {
        [SerializeField] private float _timeBorder;
        [SerializeField] private float _maxTime;
        private float _generateRandomTime = 3.0f;
        private float _currentTime;
        private bool _jumpToTheNextTime;


        protected override void Update()
        {
            AdjustRandomTime();
        }

        public override IEnumerator Spawn()
        {
            while (true)
            {
                _currentTime = 0.0f;
                SpawnData.SpawnRate = _generateRandomTime;
                var obj = GetPooledObject();
                obj.transform.position = this.transform.position;
                yield return new WaitForSeconds(SpawnData.SpawnRate);
            }
        }
        private void AdjustRandomTime()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime >= _timeBorder)
            {
                _generateRandomTime = Random.Range(3.0f, _maxTime);
            }
        }
    }
}