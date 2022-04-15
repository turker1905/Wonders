using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class SarmasikCollider : MonoBehaviour
{
    [SerializeField] float _speed;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")&& Input.GetKey(KeyCode.W))
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, _speed); 

        }

        else if (collision.gameObject.CompareTag("Player") && Input.GetKey(KeyCode.S))
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -_speed);
        }
        else
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
   
}
