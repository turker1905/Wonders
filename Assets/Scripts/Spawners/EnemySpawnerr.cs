using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerr : MonoBehaviour
{

    [SerializeField] [Range(1, 5)] float _minSpawnTime;
    [SerializeField] [Range(2, 6)] float _maxSpawnTime;
    [SerializeField] UnityEngine.Transform _meteorTransform, _enemyShipTransform;
    float _randomSpawnTimeMeteor, _randomSpawnTimeEnemyShips, _currentTimeMeteor, _currentTimeEnemyShips;
    [SerializeField] GameObject[] _meteorObject;
    [SerializeField] GameObject _enemyShipObject;

    private void FixedUpdate()
    {
        _currentTimeMeteor += Time.deltaTime;
        _currentTimeEnemyShips += Time.deltaTime;
        if (_currentTimeEnemyShips > _randomSpawnTimeEnemyShips)
        {
            EnemyShipsSpawn();
            EnemyShipsReset();
        }
        if (_currentTimeMeteor > _randomSpawnTimeMeteor)
        {
            MeteorSpawn();
            MeteorReset();
        }
    }

    private void Start()
    {
        _randomSpawnTimeMeteor = Random.Range(_minSpawnTime, _maxSpawnTime);
        _randomSpawnTimeEnemyShips = Random.Range(_minSpawnTime, _maxSpawnTime);

    }
    public void EnemyShipsSpawn()
    {
        Instantiate(_enemyShipObject, _enemyShipTransform.position, _enemyShipTransform.rotation, _enemyShipTransform);
    }

    public void MeteorSpawn()
    {
        int randomindex = Random.Range(0, _meteorObject.Length);
        Instantiate(_meteorObject[randomindex], _meteorTransform.position, _meteorTransform.rotation, _meteorTransform);
    }

    public void EnemyShipsReset()
    {
        _currentTimeEnemyShips = 0;
        _randomSpawnTimeEnemyShips = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
    public void MeteorReset()
    {
        _currentTimeMeteor = 0;
        _randomSpawnTimeMeteor = Random.Range(_minSpawnTime, _maxSpawnTime);
    }



}
