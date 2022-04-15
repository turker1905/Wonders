using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KontrolBilgiScripts : MonoBehaviour
{
    [SerializeField] GameObject _image;
    [SerializeField] Button _button1;


    public void OpenImage()
    {
        _image.SetActive(true);

    }

    public void CloseImage()
    {
        _image.SetActive(false);


    }

}
