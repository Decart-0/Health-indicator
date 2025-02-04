using UnityEngine;

public class ButtonDamage : ButtonBase<float>
{
    [SerializeField] private float _valueDamage;

    protected override void ClickButton()
    {
        HealthPlayer.TakeDamage(_valueDamage);
    }
}