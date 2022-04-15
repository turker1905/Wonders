using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : Imove
{
    public float HorizontalProp => Input.GetAxis("Horizontal")*Time.deltaTime;

    public float VerticalProp => Input.GetAxis("Vertical")*Time.deltaTime;

    public float JumpProp => Input.GetAxis("Jump");


    public void HorizontalMove(Transform _transform,float _hSpeed,bool _isHorizontalActive)
    {
        switch (_isHorizontalActive)
        {
            case true:

                _transform.position += new Vector3(HorizontalProp * _hSpeed, 0);
                break;

            default:
                _isHorizontalActive = false;
                break;
        }
    } 
    
    public void VerticalMove(Transform _transform,float _vSpeed,bool _isVerticalActive)
    {
        switch (_isVerticalActive)
        {
            case true:

                _transform.position += new Vector3(0,VerticalProp * _vSpeed);
                break;

            default:
                _isVerticalActive = false;
                break;
        }
    }

    public void JumpMove(UnityEngine.Rigidbody2D _rigid, float _jSpeed,bool _isJumpActive)
    {
        switch (_isJumpActive)
        {

            case true:
                _rigid.AddForce(Vector2.up * _jSpeed);
                break;
           

        }


    }



}




