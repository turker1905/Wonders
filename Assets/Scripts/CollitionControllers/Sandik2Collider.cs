using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sandik2Collider : MonoBehaviour
{
    bool _fBasildi;
    [SerializeField] Text _text;
    [SerializeField] GameObject _sandik2, _gemiSilah, _tornavida;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _text.text = "Acmak icin f basýn";
        }

        if (_fBasildi)
        {
            _fBasildi = false;
            _sandik2.SetActive(false);
            _gemiSilah.SetActive(true);
            _tornavida.SetActive(true);
            _text.text = "";  
        }
    }

    
    private void OnCollisionExit2D(Collision2D collision)
    {
        _fBasildi = false;
        _text.text = "";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _fBasildi = true;
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            _fBasildi = false;
        }
    }
}
