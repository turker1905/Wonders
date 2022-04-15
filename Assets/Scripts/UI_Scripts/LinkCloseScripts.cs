using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinkCloseScripts : MonoBehaviour
{
    [SerializeField] Button _butonClose;
    [SerializeField] GameObject _TextBilgi;

    public void ButtonClose()
    {
        _TextBilgi.SetActive(false);
    }

}
