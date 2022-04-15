using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OkScript : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _UI,_main;
    [SerializeField] Text _scorText,_nickText;
    int _toplamSkor;
    string _nickname;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            _UI.SetActive(true);
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
