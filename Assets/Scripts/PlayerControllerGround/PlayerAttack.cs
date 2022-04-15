using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject _mermiSpawner;
    [SerializeField] int attackDamage;
    YerBossCan _enemy;
    private void Awake()
    {
        _enemy = new YerBossCan();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Attack()
    {
        //_mermiSpawner.SetActive = true;
        // mermi icine yazilicak -> _enemy.GetComponent<YerBossCan>().TakeDamage(attackDamage);
        
    }

}
