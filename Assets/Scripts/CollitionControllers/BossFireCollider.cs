using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFireCollider : MonoBehaviour
{
    GameObject _main;
    GameObject _healthBar;
    
    public bool _aktifMi3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Arka")&& collision.gameObject.tag != "Player" )
        {
            _healthBar.GetComponent<HealthBar>()._aktifMii3 = false;
            //_aktifMi3 = false;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            //_aktifMi3 = true;
            _healthBar.GetComponent<HealthBar>()._aktifMii3 = true;
            _main.GetComponent<SkorrScene3>()._skor3 -= 50; 
        }
        
    }
    private void Awake()
    {
        _main = GameObject.Find("Main");
        _healthBar = GameObject.Find("HealthBar");
    }
}
