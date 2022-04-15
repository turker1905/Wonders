using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RekorScripts : MonoBehaviour
{
    [SerializeField] GameObject _kupaImage;
    [SerializeField] Text _text;
    public void KupaGetir()
    {
        _text.text = PlayerPrefs.GetString("KullaniciAdi1") +" = "+ PlayerPrefs.GetInt("ToplamSkor");
        
        _kupaImage.SetActive(true);

    }


}
