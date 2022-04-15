using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour
{
    [SerializeField] Rigidbody2D _playerRigid;
    [SerializeField] Collider2D _altDuvar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mermi1"))
        {
            Destroy(collision.gameObject);
            _playerRigid.gravityScale =1;
            _altDuvar.isTrigger = true;
        }
    }

    
}
