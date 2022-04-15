using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBossTrigger : MonoBehaviour
{

    [SerializeField] Rigidbody2D _bossRigid;
    [SerializeField] float _bossSpeed,_bossReturnSpeed;
    [SerializeField] SpriteRenderer _bossSprite;
    [SerializeField] GameObject _bossObject;
    [SerializeField] Animator _anim;
    [SerializeField] GameObject _ui;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _bossRigid.velocity = new Vector2(-_bossSpeed * Time.deltaTime, 0);
            _bossSprite.flipX = false;
            _anim.Play("BossWalkAnim");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BossStopTrigger2"))
        {
            _bossRigid.velocity = new Vector2(0, 0);
            _bossSprite.flipX = false;
        }
        //if (collision.gameObject.CompareTag("BossStopTrigger"))
        //{
        //    //_bossRigid.velocity *= -1f;
        //    ////_bossObject.transform.position = new Vector3(146.4f, -11.554f);
        //    //_bossSprite.flipX = true;
        //}
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            _bossSprite.flipX = true;
            _bossRigid.velocity = new Vector2(_bossReturnSpeed * Time.deltaTime, 0);
            

        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _anim.SetTrigger("BossVur");

            Invoke("Finish", 1);

        }
    }
   
    void Finish()
    {
        Time.timeScale = 0;
        _ui.SetActive(true);
    }
}
