using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaglamGemiCollider : MonoBehaviour
{
    [SerializeField] Text _gBasText;
    bool _gBasildi;
    [SerializeField] GameObject _player;
    [SerializeField] Rigidbody2D _saglamGemi;
    [SerializeField] Collider2D _sol, _ust;
    [SerializeField] GameObject _portal;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _gBasText.text = "Binmek icin G basin";

            if (_gBasildi)
            {
                _player.SetActive(false);
                
                _gBasText.text = "";
                _saglamGemi.bodyType = RigidbodyType2D.Dynamic;
                _sol.isTrigger = false;
                _ust.isTrigger = false;
                GetComponent<ShipController>()._isHorizontalActive = true;
                GetComponent<ShipController>()._isVerticalActive = true;
                _portal.SetActive(true);
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _gBasText.text = "";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            _gBasildi = true;
        }

        if (Input.GetKeyUp(KeyCode.G))
        {
            _gBasildi = false;
        }
    }
}
