using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorrScene3 : MonoBehaviour
{
    public int _skor3;
    [SerializeField] Text _skorText;

    private void Start()
    {
        _skor3 = PlayerPrefs.GetInt("Skor");
        _skorText.text = _skor3.ToString();
    }
    private void Update()
    {
        _skorText.text = _skor3.ToString();
    }
}
