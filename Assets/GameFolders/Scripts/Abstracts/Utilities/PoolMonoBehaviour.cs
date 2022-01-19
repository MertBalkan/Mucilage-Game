using System.Collections;
using System.Collections.Generic;
using MucilageGame.Concretes.Controllers;
using MucilageGame.Concretes.ScriptableObjects;
using UnityEngine;

namespace MucilageGame.Abstracts.Pools
{
    public abstract class PoolMonoBehaviour : MonoBehaviour
    {

        [SerializeField] private SpawnerSO _spawnData;
        [SerializeField] private int _poolSize;
        [SerializeField] private Queue<GameObject> _pooledObjects;
        [SerializeField] private Vector3 _rotationVector;
        [SerializeField] private GameObject _items;
        public Queue<GameObject> PooledObjects { get => _pooledObjects; set => _pooledObjects = value; }
        public SpawnerSO SpawnData { get => _spawnData; set => _spawnData = value; }

        protected virtual void Awake()
        {
            PooledObjects = new Queue<GameObject>();

            for (int i = 0; i < _poolSize; i++)
            {
                GameObject obj = InstantiateObject();
                obj.transform.parent = _items.gameObject.transform;
                obj.gameObject.SetActive(false);
                PooledObjects.Enqueue(obj);

            }
        }
        protected virtual void Start()
        {
            StartCoroutine(Spawn());
        }
        protected virtual void Update()
        {
            
        }

        public GameObject GetPooledObject()
        {
            GameObject obj = PooledObjects.Dequeue();

            obj.gameObject.SetActive(true);
            PooledObjects.Enqueue(obj);

            return obj;
        }
        public abstract IEnumerator Spawn();

        public GameObject InstantiateObject()
        {
            GameObject obj = Instantiate(
                _spawnData.SpawnPrefabs[Random.Range(0, _spawnData.SpawnPrefabs.Count)], 
                this.transform.position, 
                Quaternion.Euler(_rotationVector)
                );

            return obj;
        }

        public void DisableObjectFromQueue(Collider other)
        {
            foreach (var poolObject in _pooledObjects)
            {
                if (other.gameObject.Equals(poolObject.gameObject))
                {
                    //Change scale by time using time and scale
                    other.gameObject.SetActive(false);
                }
            }
        }
    }
}