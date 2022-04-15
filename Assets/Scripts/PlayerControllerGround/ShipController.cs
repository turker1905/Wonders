using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    MoveComponent _move;
    [SerializeField] Transform _transform;
    [SerializeField] float _hSpeed, _vSpeed;
    [SerializeField] public bool _isHorizontalActive, _isVerticalActive;
    [SerializeField] Rigidbody2D _rigid;
    
    


   
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

   

    

    private void FixedUpdate()
    {
     
        Vertical();
        Horizontal();
    }
}
