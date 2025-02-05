using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action Changed;

    [field: SerializeField] public float MaxNumber { get; private set; }

    [field: SerializeField] public float Number { get; private set; }

    public void Restore(float amount)
    {
        Number += amount;

        if (Number > MaxNumber)
        {
            Number = MaxNumber; 
        }

        Changed?.Invoke();
    }

    public void TakeDamage(float damage)
    {
        Number -= damage;       

        if (Number <= 0)
        {
            Number = 0;
        }

        Changed?.Invoke();
    }
}