using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthCounter : MonoBehaviour
{
    public static HealthCounter instance;
    public TMP_Text healthText;
    public PlayerHealth playerHealth;
    public float currentHealth;
    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

        healthText.text = currentHealth.ToString();

        currentHealth = playerHealth.currentHealth;
    }

    public void IncreaseHealth(float v)
    {

        currentHealth = v;
        healthText.text = currentHealth.ToString();

    }

    public void DecreaseHealth(int v)
    {

        currentHealth -= v;
        healthText.text = currentHealth.ToString();

    }
}
