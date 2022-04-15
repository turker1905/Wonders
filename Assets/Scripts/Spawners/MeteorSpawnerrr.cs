using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawnerrr : MonoBehaviour
{
    [SerializeField] GameObject[] _meteorObject;
    [SerializeField] Transform _meteorTransform;
    float _currentTimeMeteor, _randomSpawnTimeMeteor;
    [SerializeField] [Range(1, 5)] float _minSpawnTime;
    [SerializeField] [Range(3, 9)] float _maxSpawnTime;
    public void MeteorSpawn()
    {
        int randomindex = Random.Range(0, _meteorObject.Length);
        Instantiate(_meteorObject[randomindex], _meteorTransform.position, _meteorTransform.rotation);
    }

    public void MeteorReset()
    {
        _currentTimeMeteor = 0;
        _randomSpawnTimeMeteor = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
    
    void Start()
    {
        _randomSpawnTimeMeteor = Random.Range(_minSpawnTime, _maxSpawnTime);
    }

    private void FixedUpdate()
    {
        _currentTimeMeteor += Time.deltaTime;
        if (_currentTimeMeteor > _randomSpawnTimeMeteor)
        {
            MeteorSpawn();
            MeteorReset();
        }
    }
}
