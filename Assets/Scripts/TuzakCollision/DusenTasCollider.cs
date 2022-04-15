using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DusenTasCollider : MonoBehaviour
{
    int _toplamSkor;
    [SerializeField] GameObject _ui,_main;
    [SerializeField] Text _scorText,_nicknameText;
    string _nickname;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _ui.SetActive(true);
            Time.timeScale = 0;
            _scorText.text = $"Skorunuz = {_toplamSkor}";
            if (_toplamSkor > PlayerPrefs.GetInt("ToplamSkor"))
            {
                PlayerPrefs.SetInt("ToplamSkor", _toplamSkor);
                PlayerPrefs.SetString("KullaniciAdi1", _nickname);
            }

        }
        if (collision.gameObject.CompareTag("Tuzak"))
        {
            gameObject.SetActive(false);
            
        }
    }
    private void Start()
    {
        
    }
    void Update()
    {
        _toplamSkor = _main.GetComponent<SkorrScene2>()._skor;
    }
    private void LateUpdate()
    {
        _nickname = _nicknameText.text;
    }
}
