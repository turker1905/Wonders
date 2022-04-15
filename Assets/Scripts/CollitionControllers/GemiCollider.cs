using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemiCollider : MonoBehaviour
{
    public bool _tornavida, _tamirkit,_fBasildi;
    [SerializeField] GameObject _saglamGemi, _bozukGemi,_tornavidaImage,_tamirKitImage,_gemiSilahImage;
    [SerializeField] Text _fBasText;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _fBasText.text = "Gemiyi tamir etmek icin birseyler bulmalisin";
           
        }
        if (_tornavida == true && _tornavida == true)
        {
            _fBasText.text = "Tamir etmek icin f bas";
            if (_fBasildi)
            {
                _fBasText.text = "";
                _bozukGemi.SetActive(false);
                _saglamGemi.SetActive(true);
                _tornavidaImage.SetActive(false);
                _tamirKitImage.SetActive(false);
                _gemiSilahImage.SetActive(false);
            }


        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _fBasText.text = "";
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
