using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SonSkorScript : MonoBehaviour
{
    [SerializeField] Text _sonSkorText, _skorText;


    private void Update()
    {
        _sonSkorText.text = $"Skorunuz : {_skorText.text}";
    }
}
