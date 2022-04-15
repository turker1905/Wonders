using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayScripts : MonoBehaviour
{
    //[SerializeField] Text _nameText;
    public void StartButon()
    {
        //PlayerPrefs.SetString("NickName",_nameText.text);
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
