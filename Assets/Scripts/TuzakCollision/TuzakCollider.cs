using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuzakCollider : MonoBehaviour
{
    [SerializeField] GameObject _ok;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _ok.SetActive(true);
        }
    }
}
