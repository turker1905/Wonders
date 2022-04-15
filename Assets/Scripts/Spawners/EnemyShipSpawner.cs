using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipSpawner : MonoBehaviour
{

    [SerializeField] [Range(1, 5)] float _minSpawnTime;
    [SerializeField] [Range(2, 6)] float _maxSpawnTime;
    [SerializeField] GameObject _enemyShipObject;
    float _currentTimeEnemyShips, _randomSpawnTimeEnemyShips;

    [SerializeField] UnityEngine.Transform  _enemyShipTransform;
    public void EnemyShipsSpawn()
    {
        Instantiate(_enemyShipObject, _enemyShipTransform.position, _enemyShipTransform.rotation);
    }
    public void EnemyShipsReset()
    {
        _currentTimeEnemyShips = 0;
        _randomSpawnTimeEnemyShips = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
    private void Start()
    {
        _randomSpawnTimeEnemyShips = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
    private void FixedUpdate()
    {
        _currentTimeEnemyShips += Time.deltaTime;
        if (_currentTimeEnemyShips > _randomSpawnTimeEnemyShips)
        {
            EnemyShipsSpawn();
            EnemyShipsReset();
        }

    }
}
