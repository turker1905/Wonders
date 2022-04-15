using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sandık1Collider : MonoBehaviour
{

    [SerializeField] GameObject _sandik1;
    [SerializeField] GameObject _key;
    [SerializeField] GameObject _gun1;
    [SerializeField] Text _fBasText;
    bool _fBasildi;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _fBasText.text = "Acmak icin f basın";
        }

        
        if (_fBasildi)
        {
            _fBasildi = false;
            _sandik1.SetActive(false);
            _key.SetActive(true);
            _gun1.SetActive(true);
            _fBasText.text = "";
            
        }
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

    private void OnCollisionExit2D(Collision2D collision)
    {
        _fBasText.text = "";
    }
}
