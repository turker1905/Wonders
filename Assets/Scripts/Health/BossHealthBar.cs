using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    [SerializeField] Text _nickText;
    
    

    [SerializeField] public float _maxHealth = 100, _currentHealth;
    [SerializeField] public bool _aktifMiBoss;
    [SerializeField] GameObject _spawners;
    [SerializeField] GameObject _portal;
    int _toplamSkor;
    string _nickname;
    [SerializeField] GameObject _main,_playerHealth;
    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(float health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    private void Start()
    {
        _currentHealth = _maxHealth;
        SetMaxHealth(_maxHealth);
        
    }

    private void FixedUpdate()
    {

        Damage();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mermi"))
        {
            Destroy(collision.gameObject);
            _aktifMiBoss = true;
        }

        if (collision.gameObject.tag == "Arka" && collision.gameObject.tag !="Mermi")
        {
            _aktifMiBoss = false;
        }
    }
    
    
    public void Damage()
    {
        if (_aktifMiBoss)
        {
            _currentHealth -= 100f * Time.deltaTime;
            SetHealth(_currentHealth);
            _aktifMiBoss = false;
        }

    }

    void BossDead()
    {
        if (slider.value == 0)
        {
            Destroy(gameObject);
            _spawners.SetActive(false);
            _portal.SetActive(true);
            _playerHealth.GetComponent<HealthBar>()._aktifMii1 = false;
            _playerHealth.GetComponent<HealthBar>()._aktifMii2 = false;
            _playerHealth.GetComponent<HealthBar>()._aktifMii3 = false;
            

            if (_toplamSkor> PlayerPrefs.GetInt("ToplamSkor"))
            {
                PlayerPrefs.SetInt("ToplamSkor", _toplamSkor);
                PlayerPrefs.SetString("KullaniciAdi1", _nickname);
            }
            
            
        }
    }
     
    void Update()
    {
        BossDead();
        _toplamSkor = _main.GetComponent<SkorrScene3>()._skor3;
        Debug.Log(_toplamSkor);
        

    }
    private void LateUpdate()
    {
        _nickname = _nickText.text;
    }

}
