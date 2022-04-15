using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscButon : MonoBehaviour
{
    [SerializeField] GameObject EscUI;

    private void FixedUpdate()
    {
        EscButon1();
    }


    void EscButon1()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            EscUI.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
