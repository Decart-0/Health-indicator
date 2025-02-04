using System;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public event Action ChangedHealth;

    [field: SerializeField] public float MaxHealth { get; private set; }

    [field: SerializeField] public float Health { get; private set; }

    public void Restore(float amount)
    {
        Health += amount;

        if (Health > MaxHealth)
        {
            Health = MaxHealth; 
        }

        ChangedHealth?.Invoke();
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        ChangedHealth?.Invoke();

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}