using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TornavidaCollider : MonoBehaviour
{
    [SerializeField] Text _fBasText;
    [SerializeField] GameObject _reward;
    [SerializeField] GameObject _rewardObject;
    [SerializeField] GameObject _gemi;
    

    bool _fBasildi;
    public bool _anahtarAlindi;
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            _fBasText.text = "Almak icin f basin";



            if (_fBasildi)
            {
                _reward.SetActive(true);
                _rewardObject.SetActive(false);
                _gemi.GetComponent<GemiCollider>()._tornavida = true;
                _fBasText.text = "";
                
                _fBasildi = false;
            }



        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _fBasText.text = "";
        _fBasildi = false;
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
