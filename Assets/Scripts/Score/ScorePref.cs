using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePref : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    int _skor;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = $"{PlayerPrefs.GetInt("Skor")}";
        
        Debug.Log(_skor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
