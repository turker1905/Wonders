using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipCollision2 : MonoBehaviour
{
    public int _score2;
    public static bool _aktifMi2, _a2;
    GameObject _main, _health;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mermi"))
        {
            //_score2 += 20;
            _main.GetComponent<SkorrScene3>()._skor3 += 100;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            //_aktifMi2 = true;
            _health.GetComponentInChildren<HealthBar>()._aktifMii2 = true;
            //_score2 -= 10;
            _main.GetComponent<SkorrScene3>()._skor3 -= 50;
        }

        if (collision.gameObject.tag == "Arka" && collision.gameObject.tag != "Player")
        {
            _aktifMi2 = false;
            _health.GetComponentInChildren<HealthBar>()._aktifMii2 = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _aktifMi2 = false;
            _health.GetComponentInChildren<HealthBar>()._aktifMii2 = false;
        }
    }

    void VeriGonder()
    {
        PlayerPrefs.SetInt("Sonuc1", _score2);
    }
    private void Awake()
    {
        PlayerPrefs.GetInt("Sonuc1");
        _main = GameObject.Find("Main");
        _health = GameObject.Find("Player");
    }
    private void Update()
    {
        VeriGonder();
    }
}
