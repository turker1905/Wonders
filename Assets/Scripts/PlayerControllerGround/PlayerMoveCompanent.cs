using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveCompanent : IPlayerMove
{
    public float Horizontal =>Input.GetAxis("Horizontal");

    public float Vertical =>Input.GetAxis ("Vertical");

    public float Jump => Input.GetAxis("Jump");

    public void PlayerXAxis(Transform _playerXAxis, float _playerXspeed, bool _xActive)
    {
        if (_xActive)
        {
            _playerXAxis.position += new Vector3(Horizontal * _playerXspeed * Time.deltaTime, 0);       
        }
        
    } 
    public void PlayerYAxis(Transform _playerYAxis, float _playerYspeed, bool _yActive)
    {
        if (_yActive)
        {
            _playerYAxis.position += new Vector3(0, Vertical * _playerYspeed * Time.deltaTime);
        }        
    }
    public void PlayerJumpAxis(Rigidbody2D _playerJumpAxis, float _playerJumpSpeed, bool _jumpActive)
    {
        if (_jumpActive)
        {
            _playerJumpAxis.AddForce(Vector2.up*_playerJumpSpeed);
        }
    }
}
