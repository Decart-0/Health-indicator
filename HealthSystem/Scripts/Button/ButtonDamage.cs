using UnityEngine;

public class ButtonDamage : ButtonBase<float>
{
    [SerializeField] private float _valueDamage;

    protected override void ClickButton()
    {
        _healthPlayer.TakeDamage(_valueDamage);
    }
}