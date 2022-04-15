using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanSpawner : MonoBehaviour
{
    [SerializeField] [Range(1,10)] float _minRandomDeger;
    [SerializeField] [Range(2,15)] float _maxRandomDeger;
    [SerializeField]float _currentTime, _randomTime;
    [SerializeField] GameObject _gemi;
    [SerializeField]Transform _gemiSpawner;

    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        DusmanSpawn();
    }

    void DusmanSpawn()
    {
        
        if (_currentTime>_randomTime)
        {
            Instantiate(_gemi, _gemiSpawner.position, _gemiSpawner.rotation);
            _currentTime = 0;
            _randomTime = Random.Range(_minRandomDeger, _maxRandomDeger);
        }



    }

    private void Start()
    {
        _randomTime = Random.Range(_minRandomDeger, _maxRandomDeger);
    }
}
