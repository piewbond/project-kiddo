using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int maxHealth = 16;
    public int health = 16;

    [SerializeField] private HPUIController hpUIController;


    void Start()
    {

    }

    void Update()
    {
        //TODO: remove
        hpUIController.UpdateHealthUI(health);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            health = 0;
        }
        hpUIController.UpdateHealthUI(health);
    }

    public void Heal(int amount)
    {
        health += amount;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        hpUIController.UpdateHealthUI(health);
    }
}
