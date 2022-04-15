using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimScript : MonoBehaviour
{
    [SerializeField] Animator _anim;
    string current;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    void ChangeAnim(string newState)
    {
        if (current == newState) return;
        _anim.Play(newState);
        current = newState;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ChangeAnim("BossVurAnim");
        }
    }
}
