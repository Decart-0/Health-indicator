using UnityEngine;

public class ButtonHeal : ButtonBase<float>
{
    [SerializeField] private float _valueHeal;

    protected override void ClickButton()
    {
        _healthPlayer.Restore(_valueHeal);
    }
}