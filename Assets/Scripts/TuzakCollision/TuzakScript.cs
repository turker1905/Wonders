using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TuzakScript : MonoBehaviour
{
    int _toplamSkor;
    [SerializeField] GameObject _ui,_main;
    [SerializeField] Text _scorText,_nickText;
    string _nickname;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            _ui.SetActive(true);
            _scorText.text = $"Skorunuz = {_toplamSkor}";
            if (_toplamSkor > PlayerPrefs.GetInt("ToplamSkor"))
            {
                PlayerPrefs.SetInt("ToplamSkor", _toplamSkor); 
                PlayerPrefs.SetString("KullaniciAdi1", _nickname);
            }
        }
    }

    void Update()
    {
        _toplamSkor = _main.GetComponent<SkorrScene2>()._skor;
    }
    private void Start()
    {
        
    }
    private void LateUpdate()
    {
        _nickname = _nickText.text;
    }
}
