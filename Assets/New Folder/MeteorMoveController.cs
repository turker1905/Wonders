using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMoveController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigid;
    [SerializeField] float _meteorDownSpeed,_meteorLeftSpeed,_meteorUpSpeed;

    void MeteorSpeed()
    {
        _rigid.velocity = Vector2.left*_meteorLeftSpeed + Vector2.down*_meteorDownSpeed+ Vector2.up*_meteorUpSpeed;
    }

    private void FixedUpdate()
    {
        MeteorSpeed();
    }
}
