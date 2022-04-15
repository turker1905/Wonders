using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NickNameScripts : MonoBehaviour
{
    [SerializeField] InputField _inputField;
    [SerializeField] GameObject _button1;
    
    
    public void Nickname()
    {
        PlayerPrefs.SetString("KullaniciAdi", _inputField.text);
        if (_inputField.text.Length>0)
        {
            _button1.SetActive(true);
        }
        else
        {
            _button1.SetActive(false);
        }
        
    }


}
