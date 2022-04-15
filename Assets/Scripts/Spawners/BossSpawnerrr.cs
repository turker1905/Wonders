using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnerrr : MonoBehaviour
{
    [SerializeField] GameObject _spawner, _kocaKafaliBoss;
    [SerializeField] float _gameTime;
    [SerializeField] float _currentTime;
    [SerializeField] Collider2D _collider;
    void BossSpawn()
    {
        if (_currentTime>_gameTime)
        {
            _spawner.SetActive(false);
            _kocaKafaliBoss.SetActive(true);
            _collider.isTrigger = false;
        }
    }
    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        
        BossSpawn();
    }
    void Start()
    {
        _currentTime = 0;
    }
   
    void Update()
    {
        
    }
}
