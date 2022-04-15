using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigers : MonoBehaviour
{
    [SerializeField] Rigidbody2D _bossRigid;
    [SerializeField] GameObject Mermiler;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boss"))
        {
            _bossRigid.constraints = RigidbodyConstraints2D.FreezePositionX;
            
            Mermiler.SetActive(true);
        }
    }
}
