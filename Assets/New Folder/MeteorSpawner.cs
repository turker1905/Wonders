using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    private void Start()
    {
        _randomTime = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
    float _currentTime;

    [SerializeField] [Range(3,6)]float _minSpawnTime;
    [SerializeField] [Range(5,10)]float _maxSpawnTime;
    float _randomTime;
    [SerializeField] GameObject _meteor;
    [SerializeField] Transform _spawnerTransform;
    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        MeteorSpawn();
    }

    void MeteorSpawn()
    {
        
        if (_currentTime>_randomTime)
        {
            Instantiate(_meteor, _spawnerTransform.position, _spawnerTransform.rotation);
            _currentTime = 0;
            _randomTime = Random.Range(_minSpawnTime, _maxSpawnTime);
        }
    }
}
