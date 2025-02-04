using UnityEngine;

public class ButtonHeal : ButtonBase<float>
{
    [SerializeField] private float _valueHeal;

    protected override void ClickButton()
    {
        HealthPlayer.Restore(_valueHeal);
    }
}