using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetoerCollision : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    public  int _health1; 
    public  int _scoree;
    public  static bool _aktifMi;
    bool _active;
     GameObject _main,_health,_health2;
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mermi"))
        {
            //_scoree += 15;
            //_scoreText.text = _scoree.ToString();
            //Debug.Log(_scoree);

            _main.GetComponent<Skorr>()._sonuc += 100;
            Destroy(gameObject);
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == ("Arka") && collision.gameObject.tag !="Player")
        {
            //_aktifMi = false;
            _health.GetComponent<HealthBarScene1>()._aktifMii1 = false;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            //_aktifMi = true;
            _health.GetComponent<HealthBarScene1>()._aktifMii1 = true;
            _main.GetComponent<Skorr>()._sonuc -= 50;
            //_health2.GetComponent<HealthBar2>()
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _scoree -= 10;
            Destroy(gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
       
    }
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
    private void Awake()
    {
        _main = GameObject.Find("Main");
        _health = GameObject.Find("HealthBar");
        
    }
}
