using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AltDuvarTrigger : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    public int _b;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
            PlayerPrefs.SetInt("Skor", _b);
            _scoreText.text = _b.ToString();
        }
    }
}
