using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuzak1Trigger : MonoBehaviour
{
    [SerializeField] GameObject _tuzak1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _tuzak1.SetActive(true);
        }
    }
}
