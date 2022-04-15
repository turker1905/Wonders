using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnahtarAlindiProp 
{
    public bool AnahtarAlindi { get; set; }
    bool _anahtar;

    public void Anahtar()
    {

        if (AnahtarAlindi)
        {
            _anahtar = true;
            Debug.Log("Anahtar alindi");

        }

        else
        {
            Debug.Log("Anahtar Alinmadi");
        }
    }
    
    
}
