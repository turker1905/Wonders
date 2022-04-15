using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skorr : MonoBehaviour
{
    public int _sonuc;
    [SerializeField] Text _text;
    [SerializeField] GameObject _skor;
    private void Update()
    {
        _skor.GetComponent<AltDuvarTrigger>()._b = _sonuc;
        _text.text = $"Skor : {_sonuc.ToString()}";
    }


}
