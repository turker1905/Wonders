using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi1Collider : MonoBehaviour
{
    public static bool _aktifMiMermi1;
    GameObject _health;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _aktifMiMermi1 = true;
            _health.GetComponent<HealthBarScene1>()._aktifMii4 = true;
        }

        
    }

    private void Start()
    {
        _health = GameObject.Find("HealthBar");
    }
}
