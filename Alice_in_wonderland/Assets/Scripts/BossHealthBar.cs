using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
    public Slider healthSlider;
    

    Damageable bossDamageable;

    private void Awake()
    {
        GameObject boss = GameObject.FindGameObjectWithTag("Boss"); // 

        if (boss == null)
        {
            Debug.Log("Khong tim thay boss trong man choi");
        }

        bossDamageable = boss.GetComponent<Damageable>();
    }

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.value = CalculateSliderPercentage(bossDamageable.Health, bossDamageable.MaxHealth);
      
    }

    private void OnEnable()
    {
        bossDamageable.healthChanged.AddListener(OnBossHealthChanged);
    }

    private void OnDisable()
    {
        bossDamageable.healthChanged.RemoveListener(OnBossHealthChanged);
    }

    private float CalculateSliderPercentage(float currentHealth, float maxHealth)
    {
        return currentHealth / maxHealth;
    }

    private void OnBossHealthChanged(int newHealth, int maxHealth)
    {
        healthSlider.value = CalculateSliderPercentage(newHealth, maxHealth);
        
    }
}
