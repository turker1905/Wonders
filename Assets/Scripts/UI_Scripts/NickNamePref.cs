using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NickNamePref : MonoBehaviour
{
    [SerializeField] Text _kullaniciAdiText;
    // Start is called before the first frame update
    void Start()
    {
        _kullaniciAdiText.text =  PlayerPrefs.GetString("KullaniciAdi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
