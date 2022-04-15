using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    MoveComponent _move;
    [SerializeField] Transform _transform;
    [SerializeField] float _hSpeed,_vSpeed,_jSpeed;
    [SerializeField] bool _isHorizontalActive,_isVerticalActive,_isJumpActive;
    [SerializeField] Rigidbody2D _rigid;
    [SerializeField] bool _jActive;
    [SerializeField] bool _grounded;
    

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zemin")
        {
            _grounded = true;
        }
    }
    private void Awake()
    {
        _move = new MoveComponent();
    }


    void Horizontal()
    {
        _move.HorizontalMove(_transform, _hSpeed, _isHorizontalActive);
        if (Input.GetKey(KeyCode.D))
        {

        }
    } 

    void Vertical()
    {
        _move.VerticalMove(_transform, _vSpeed, _isVerticalActive);
    }

    void Jump()
    {
        if (_jActive && _grounded)
        {
            _move.JumpMove(_rigid, _jSpeed, _isJumpActive);
        }
        _jActive = false;
        _grounded = false;
    }
    private void Update()
    {
        _jActiveCheck();
    }
    void _jActiveCheck()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jActive = true;
        }
        

    }
  
    private void FixedUpdate()
    {
        Jump();
        Vertical();
        Horizontal();        
    }
    
}
