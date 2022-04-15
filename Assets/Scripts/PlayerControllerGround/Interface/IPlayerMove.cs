using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerMove
{
    public float Horizontal { get;}
    public float Vertical { get;}
    public float Jump { get;}
}
