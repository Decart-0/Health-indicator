using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonBase<T> : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] protected HealthPlayer _healthPlayer;

    private void OnEnable()
    {
        _button.onClick.AddListener(ClickButton);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ClickButton);
    }

    protected virtual void ClickButton() {}
}