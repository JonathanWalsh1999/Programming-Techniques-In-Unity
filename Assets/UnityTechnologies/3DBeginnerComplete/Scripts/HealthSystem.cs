using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public delegate void HealthChanged(int currentHealth, int maxHealth);
    public static event HealthChanged OnHealthChanged;

    [SerializeField]
    private int m_maxHealth = 100;

    private int m_currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        m_currentHealth = m_maxHealth;


        OnHealthChanged?.Invoke(m_currentHealth, m_maxHealth);
        
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        m_currentHealth -= damage;
        if(m_currentHealth < 0)
        {
            m_currentHealth = 0;
        }

        OnHealthChanged?.Invoke(m_currentHealth, m_maxHealth);

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //Take damage
            TakeDamage(10);
            Debug.Log(m_currentHealth);
        }
    }


}
