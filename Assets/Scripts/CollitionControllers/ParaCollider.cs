using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaCollider : MonoBehaviour
{
    GameObject _skor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            _skor.GetComponent<SkorrScene2>()._skor += 25;
        }
    }
    private void Awake()
    {
        _skor = GameObject.Find("Main");
    }

}
