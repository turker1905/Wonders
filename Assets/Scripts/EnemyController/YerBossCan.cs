using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YerBossCan : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] int maxhp = 100;
    int currenthp;

    private void Start()
    {
        currenthp = maxhp;
    }

    public void TakeDamage(int damage)
    {
        currenthp -= damage;

        _animator.SetTrigger("BossHurtAnim");

        if (currenthp <= 0)
        {
            Die();
        }
    }

    void Die()
    {

        _animator.SetBool("BossOlAnim", true);
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }


}
