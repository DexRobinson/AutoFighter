using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private string chatacterName;

    private float currentHealth;
    private float maxHealth;

    private float attackDamage;
    private float armor;
    private float attackSpeed;
    private float attackRange;
    private float movementSpeed;

    public virtual void Death()
    {
        
    }

    public void RemoveHealth(float amt)
    {
        float newHealth = currentHealth - (amt - armor);
        currentHealth = Mathf.Clamp(newHealth, 1, amt);
        if(currentHealth <= 0)
        {
            Death();
        }
    }
}
