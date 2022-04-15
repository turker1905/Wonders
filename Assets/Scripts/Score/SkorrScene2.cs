using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorrScene2 : MonoBehaviour
{
    public int _skor;
    [SerializeField] Text _skortext;
    [SerializeField] GameObject _portal;
    private void Start()
    {
       _skor =  PlayerPrefs.GetInt("Skor");
        _skortext.text = _skor.ToString();
    }
    private void Update()
    {
        _skortext.text = _skor.ToString();
        _portal.GetComponent<PortalCollider>()._c = _skor;
    }
}
