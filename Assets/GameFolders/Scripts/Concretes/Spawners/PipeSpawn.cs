using System.Collections;
using System.Collections.Generic;
using MucilageGame.Concretes.Controllers;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _partPrefab, _parentObject;
    [SerializeField] [Range(1, 1000)] private int _lenght = 1;
    [SerializeField] private float _partDistance = 0.21f;
    [SerializeField] private bool _reset, _spawn, _snapFirst, _snapLast;
    [SerializeField] private GameObject _car;

    void FixedUpdate()
    {
        if (_reset)
            foreach (GameObject tmp in GameObject.FindGameObjectsWithTag("Part"))
                Destroy(tmp);
    }
    private void Start()
    {
        _parentObject.transform.parent = _car.transform;
        Spawn();

    }
    public void Spawn()
    {
        int count = (int)(_lenght / _partDistance);
        for (int x = 0; x < count; x++)
        {
            GameObject tmp;
            tmp = Instantiate(_partPrefab, new Vector3(transform.position.x, transform.position.y + _partDistance * (x + 1), transform.position.z), Quaternion.identity, _parentObject.transform);
            tmp.transform.eulerAngles = new Vector3(180, 0, 0);
            tmp.name = _parentObject.transform.childCount.ToString();

            if (x == 0)
            {
                Destroy(tmp.GetComponent<CharacterJoint>());
                if (_snapFirst)
                {
                    tmp.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                }
            }
            else
            {
                tmp.GetComponent<CharacterJoint>().connectedBody = _parentObject.transform.Find((_parentObject.transform.childCount - 1).ToString()).GetComponent<Rigidbody>();
            }
        }
        if (_snapLast)
        {
            Transform lastObj = _parentObject.transform.Find((_parentObject.transform.childCount).ToString());
            
            lastObj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            
            lastObj.transform.position = new Vector3(-5.2f,0,1);
            lastObj.transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.y, -15));
            
            lastObj.gameObject.AddComponent<PipeController>();
            //It's adding this component but in
            //NumberTextUI script it's cannot be find and gives it null value;
            //lastObj.gameObject.AddComponent<CollectorController>();
            lastObj.gameObject.tag = "LastObject";
            lastObj.GetComponent<CapsuleCollider>().isTrigger = true;

        }
    }
}
