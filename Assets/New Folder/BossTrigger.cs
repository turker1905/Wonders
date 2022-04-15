using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigid;
    [SerializeField] GameObject _bullet,_bullet1,_bullet2,_bullet3,_bullet4;

   
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BossTrigger"))
        {
            _rigid.constraints = RigidbodyConstraints2D.FreezePositionX;
            _bullet.SetActive(true);
            _bullet1.SetActive(true);
            _bullet2.SetActive(true);
            _bullet3.SetActive(true);
            _bullet4.SetActive(true);

        }
    }
}
