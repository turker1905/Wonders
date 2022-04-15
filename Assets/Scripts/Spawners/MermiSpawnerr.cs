using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiSpawnerr : MonoBehaviour
{
    [SerializeField] UnityEngine.Transform _mermiTransform;
    [SerializeField] GameObject _mermiObject;
    public void MermiSpawn()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_mermiObject, _mermiTransform.position, _mermiTransform.rotation);
        }
    }
    private void Update()
    {
        MermiSpawn();
    }
}
