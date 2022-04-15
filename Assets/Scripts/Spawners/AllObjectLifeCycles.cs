using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllObjectLifeCycles : MonoBehaviour
{
    [SerializeField] float _enemyLifeTime;
    float _currentTime;
    public void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > _enemyLifeTime)
        {
            Destroy(this.gameObject);
        }
    }
}
