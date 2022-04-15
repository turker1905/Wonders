using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletTrigger : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigid;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            _rigid.gravityScale = 3;
            _rigid.freezeRotation = false;
        }
    }
}
