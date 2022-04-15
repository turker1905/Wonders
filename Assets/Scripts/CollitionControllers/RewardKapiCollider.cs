using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardKapiCollider : MonoBehaviour
{
    public bool _anahtarVarMi;
    bool _fBasildi;
    [SerializeField] Text _reward2Text;
    [SerializeField] GameObject _kapi,_anahtar;
    private void FixedUpdate()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            _reward2Text.text = "Acmak icin f basýn";
        }

        

        if (_anahtarVarMi)   
        {
            if (_fBasildi)
            {
                _fBasildi = false;
                _kapi.SetActive(false);
                _anahtar.SetActive(false);
                _reward2Text.text = "";
                
            }
            
        }

        else
        {
            _reward2Text.text = "Anahtari bulmalisin";
        }
    }

    private void Awake()
    {
         
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
        _reward2Text.text = "";
        _fBasildi = false;
    }
}
