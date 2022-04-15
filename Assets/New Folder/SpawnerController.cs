using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    
    
    [SerializeField] GameObject _mermi1;
    [SerializeField] Transform _mermi1Spawner;
    void SpawnControl()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_mermi1, _mermi1Spawner.transform.position, _mermi1Spawner.transform.rotation);
        }

    }

    private void Update()
    {
        
        SpawnControl();
    }



}
