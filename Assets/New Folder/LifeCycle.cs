using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    [SerializeField] float _lifeTime;
    float _currentTime;

    void LifeTime()
    {
        if (_currentTime>_lifeTime)
        {
            Destroy(gameObject);
        }
    }


    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        LifeTime();
    }




}
