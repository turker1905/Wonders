using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoverComponent : MonoBehaviour
{
    [SerializeField] DirectionEnum _directionEnums;
    [SerializeField] float _dusmanHareketHizi;
    [SerializeField] Rigidbody2D _rigid;

    private void Awake()
    {
        
    }

    private void FixedUpdate()
    {
        _rigid.velocity = DirectionSelect() * Time.deltaTime * _dusmanHareketHizi;
        
    }

    Vector2 DirectionSelect()
    {
        UnityEngine.Vector2 _directionVector2;
        if (_directionEnums == DirectionEnum.left)
        {
            _directionVector2 = Vector2.left;
        }

        else if (_directionEnums == DirectionEnum.right)
        {
            _directionVector2 = Vector2.right;
        }

        else if (_directionEnums == DirectionEnum.up)
        {
            _directionVector2 = Vector2.up;
        }

        else 
        {
            _directionVector2 = Vector2.down;
        }

        return _directionVector2;
    }
}
