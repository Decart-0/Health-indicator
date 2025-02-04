using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : MonoBehaviour
{   
    private const string CharacterSeparator = "/";

    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Slider _smoothHealthBar;
    [SerializeField] private HealthPlayer _healthPlayer;

    [SerializeField] private float _smoothSpeed;

    private void OnEnable()
    {
        _healthPlayer.ChangedHealth += UpdateHealthText;
        _healthPlayer.ChangedHealth += UpdateHealthBar;
    }

    private void Update()
    {
        UpdateSmoothHealthBar();
    }

    private void OnDisable()
    {
        _healthPlayer.ChangedHealth -= UpdateHealthText;
        _healthPlayer.ChangedHealth -= UpdateHealthBar;
    }

    private void UpdateHealthText()
    {
        if (_healthText != null)
        {
            _healthText.text = _healthPlayer.Health + CharacterSeparator + _healthPlayer.MaxHealth;
        }
    }

    private void UpdateHealthBar()
    {
        if (_healthBar != null)
        {
            _healthBar.value = _healthPlayer.Health;
        }
    }

    private void UpdateSmoothHealthBar()
    {
        if (_smoothHealthBar != null)
        {
            _smoothHealthBar.value = Mathf.MoveTowards(_smoothHealthBar.value, _healthPlayer.Health, _smoothSpeed * Time.deltaTime);
        }
    }
}