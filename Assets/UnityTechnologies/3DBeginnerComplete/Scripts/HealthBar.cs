using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider m_healthSlider;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    private void OnEnable()
    {
        HealthSystem.OnHealthChanged += UpdateHealthBar;
    }

    private void OnDisable()
    {
        HealthSystem.OnHealthChanged -= UpdateHealthBar;
    }

    private void UpdateHealthBar(int currentHealth, int maxHealth)
    {
        m_healthSlider.value = (float)currentHealth / maxHealth;
    }

}
