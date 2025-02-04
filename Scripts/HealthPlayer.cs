using System;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public event Action ChangedNumberLives;

    [field: SerializeField] public float MaxNumberLives { get; private set; }

    [field: SerializeField] public float NumberLives { get; private set; }

    public void Restore(float amount)
    {
        NumberLives += amount;

        if (NumberLives > MaxNumberLives)
        {
            NumberLives = MaxNumberLives; 
        }

        ChangedNumberLives?.Invoke();
    }

    public void TakeDamage(float damage)
    {
        NumberLives -= damage;       

        if (NumberLives <= 0)
        {
            NumberLives = 0;
        }

        ChangedNumberLives?.Invoke();
    }
}