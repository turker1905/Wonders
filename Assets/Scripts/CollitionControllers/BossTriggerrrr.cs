using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTriggerrrr : MonoBehaviour
{
    [SerializeField] UnityEngine.Rigidbody2D _rigid;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boss"))
        {
            Debug.Log("Çalýþtý");
            _rigid.constraints = RigidbodyConstraints2D.FreezePositionX;
            
            
        }
      
    }

}
