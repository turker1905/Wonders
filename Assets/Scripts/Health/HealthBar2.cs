using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar2 : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    [SerializeField] Collider2D _collider;
    [SerializeField] GameObject _deadUI;

    [SerializeField] static public float _maxHealth = 100, _currentHealth = 100;
    [SerializeField] public bool _aktifMii1, _aktifMii2, _aktifMii3,_aktifMii4;
    


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


        CanKontrol();
        Damage();

        
        _aktifMii1 = MetoerCollision._aktifMi;
        _aktifMii2 = EnemyShipCollision._aktifMi2;
        //_aktifMii3 = BossFireCollider._aktifMi3;
        _aktifMii4 = Mermi1Collider._aktifMiMermi1;

    }


    void CanKontrol()
    {
        if (slider.value == 0)
        {
            Time.timeScale = 0;

            _deadUI.SetActive(true);
            //_currentHealth = _maxHealth;
            SetMaxHealth(_maxHealth);
        }
    }
    public void Damage()
    {
        if (_aktifMii1)
        {
            _currentHealth -= 10f * Time.deltaTime;
            SetHealth(_currentHealth);
            
        }

        if (_aktifMii2)
        {
            _currentHealth -= 10f * Time.deltaTime;
            SetHealth(_currentHealth);
            
        }

        if (_aktifMii3)
        {
            _currentHealth -= 20f * Time.deltaTime;
            SetHealth(_currentHealth);
            
        }

        if (_aktifMii4)
        {
            //_currentHealth -= 200f * Time.deltaTime;
            SetHealth(15);
            _deadUI.SetActive(false);
            _collider.isTrigger = true;
            Time.timeScale = 1;
            

        }
    }
   
}
