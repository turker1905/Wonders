using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{

    [SerializeField] float _currentTime;
    [SerializeField] float _oyunSüresi;
    [SerializeField] GameObject _meteorSpawner, _enemySpawner,_boss;
    [SerializeField] Transform _bossSpawner;

    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        Sayim();
    }

    void Sayim()
    {


        if (_currentTime > _oyunSüresi)
        {
            _meteorSpawner.SetActive(false);
            _enemySpawner.SetActive(false);
            _currentTime = 0;
            _boss.SetActive(true);
           
        }
        


    }

    




}
