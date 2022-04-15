using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalColliderScene3 : MonoBehaviour
{
    [SerializeField] GameObject _obje,_health,_duvar,_duvar1,_duvar2,_player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GemiKuyruk"))
        {
            _obje.SetActive(true);
            _player.SetActive(false);

        }

        if (collision.gameObject.CompareTag("Player"))
        {
            _health.SetActive(false);
            
            _duvar.SetActive(false);
            _duvar1.SetActive(true);
            _duvar2.SetActive(true);
        }
    }

    
}
