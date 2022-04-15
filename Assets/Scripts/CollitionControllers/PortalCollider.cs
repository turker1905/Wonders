using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalCollider : MonoBehaviour
{
    public int _c;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GemiKuyruk"))
        {
            SceneManager.LoadScene(3);
            PlayerPrefs.SetInt("Skor", _c);
        }
    }
}
