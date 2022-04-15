using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossOnTrigger : MonoBehaviour
{

    [SerializeField] UnityEngine.Rigidbody2D _rigidbody2D;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boss"))
        {

            _rigidbody2D.constraints = RigidbodyConstraints2D.FreezePositionX;
            _rigidbody2D.constraints = RigidbodyConstraints2D.FreezePositionY;

        }

        if (collision.gameObject.CompareTag("Duvar"))
        {
            _rigidbody2D.velocity *= -1f;
        }
    }

}

    
