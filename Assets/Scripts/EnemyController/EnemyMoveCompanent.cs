using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMoveCompanent : MonoBehaviour
{
    [SerializeField] float _dusmanHareketHizi,_dusmanHareketHizi2;
   [SerializeField] YonEnum _yonenum,_yonenum2;

    [SerializeField] Rigidbody2D _rigitbody;
    Vector2 DirectionSelect()
    {
        UnityEngine.Vector2 _Directionvector;
        if (_yonenum == YonEnum.left)
        {
            _Directionvector = Vector2.left;
        }
        else if (_yonenum == YonEnum.right)
        {
            _Directionvector = Vector2.right;

        }
        else if (_yonenum == YonEnum.up)
        {
            _Directionvector = Vector2.up;

        }
        else if (_yonenum == YonEnum.down)
        {
            _Directionvector = Vector2.down;

        }
        else
        {
            _Directionvector = Vector2.zero;
        }

        return _Directionvector;

    }
    Vector2 DirectionSelect2()
    {
        UnityEngine.Vector2 _Directionvector2;
        if (_yonenum2 == YonEnum.left)
        {
            _Directionvector2 = Vector2.left;
        }
        else if (_yonenum2 == YonEnum.right)
        {
            _Directionvector2 = Vector2.right;

        }
        else if (_yonenum2 == YonEnum.up)
        {
            _Directionvector2 = Vector2.up;

        }
        else if (_yonenum2 == YonEnum.down)
        {
            _Directionvector2 = Vector2.down;

        }
        else
        {
            _Directionvector2 = Vector2.zero;
        }

        return _Directionvector2;

    }

    private void FixedUpdate()
    {
        _rigitbody.velocity = DirectionSelect() * Time.deltaTime * _dusmanHareketHizi + DirectionSelect2() * Time.deltaTime * _dusmanHareketHizi2;
    }

    void Start()
    {
       
        


    }
 
    void Update()
    {
        


       
    }
}
