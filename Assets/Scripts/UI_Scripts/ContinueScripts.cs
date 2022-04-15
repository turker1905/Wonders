using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueScripts : MonoBehaviour
{

    [SerializeField] GameObject EscUI;

    private void Start()
    {

    }

    public void EscButon2()
    {
        EscUI.SetActive(false);
        Time.timeScale = 1;
    }


}
