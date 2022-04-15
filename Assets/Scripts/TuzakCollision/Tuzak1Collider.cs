using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuzak1Collider : MonoBehaviour
{
    [SerializeField] Rigidbody2D _tas;
    [SerializeField] GameObject _dusenTasTrigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            _tas.gravityScale = 1;
            
        }
    }
}
