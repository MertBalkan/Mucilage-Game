using System.Collections;
using System.Collections.Generic;
using MucilageGame.Abstracts.Controllers;
using MucilageGame.Concretes.Controllers;
using MucilageGame.Concretes.Enums;
using MucilageGame.Concretes.Managers;
using MucilageGame.Concretes.Pools;
using UnityEngine; 

namespace MucilageGame.Concretes.ScriptableObjects
{
    [CreateAssetMenu(fileName = "SpawnerData", menuName = "MucilageGame/SpawnerData", order = 0)]

    public class SpawnerSO : ScriptableObject
    {
        [SerializeField] private List<GameObject> _spawnPrefabs;
        [SerializeField] private float _spawnRate;
        //MAKE THIS PARAMETER DYNAMIC LATER...
        [SerializeField] private float _frequancyLimit;
        public float SpawnRate { get => _spawnRate; set => _spawnRate = value; }
        public List<GameObject> SpawnPrefabs => _spawnPrefabs;
        public float FrequancyLimit => _frequancyLimit;

        /*
        public GameObject Spawn(GameObject spawnPoint)
        {
            switch (_spawnType)
            {
                case SpawnType.Sea:
                    {
                        WaterManager.Instance.Waters.Add(_spawnPrefabs[GenerateSpawnIndex()].GetComponent<WaterController>());

                        GameObject seaObj = Instantiate(_spawnPrefabs[GenerateSpawnIndex()], spawnPoint.transform.position, Quaternion.identity);
                        return seaObj;
                    }
                case SpawnType.Barrier:
                    {
                        BarrierManager.Instance.Barriers.Add(_spawnPrefabs[GenerateSpawnIndex()].GetComponent<BarrierController>());

                        Vector3 newVector = new Vector3(-90, 0, -90);

                        GameObject barrierObj = Instantiate(_spawnPrefabs[GenerateSpawnIndex()], spawnPoint.transform.position, Quaternion.Euler(newVector));
                        return barrierObj;
                    }
                case SpawnType.Mucilage:
                    {
                        MucilageManager.Instance.Mucilages.Add(_spawnPrefabs[GenerateSpawnIndex()].GetComponent<MucilageController>());
                        
                        GameObject mucilageObj = Instantiate(_spawnPrefabs[GenerateSpawnIndex()], spawnPoint.transform.position, Quaternion.identity);
                        return mucilageObj;
                    }
                case SpawnType.Obstacle:
                    {
                        ObstacleManager.Instance.Obstacles.Add(_spawnPrefabs[GenerateSpawnIndex()].GetComponent<ObstacleController>());
                        
                        GameObject obstacleObj = Instantiate(_spawnPrefabs[GenerateSpawnIndex()], spawnPoint.transform.position, Quaternion.identity);
                        return obstacleObj;
                    }
            }
            return null;
        }*/
    }
}