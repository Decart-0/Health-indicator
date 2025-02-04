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
        _healthPlayer.ChangedNumberLives += UpdateHealthText;
        _healthPlayer.ChangedNumberLives += UpdateHealthBar;
    }

    private void Update()
    {
        UpdateSmoothHealthBar();
    }

    private void OnDisable()
    {
        _healthPlayer.ChangedNumberLives -= UpdateHealthText;
        _healthPlayer.ChangedNumberLives -= UpdateHealthBar;
    }

    private void UpdateHealthText()
    {
        if (_healthText != null)
        {
            _healthText.text = _healthPlayer.NumberLives + CharacterSeparator + _healthPlayer.MaxNumberLives;
        }
    }

    private void UpdateHealthBar()
    {
        if (_healthBar != null)
        {
            _healthBar.value = _healthPlayer.NumberLives;
        }
    }

    private void UpdateSmoothHealthBar()
    {
        if (_smoothHealthBar != null)
        {
            _smoothHealthBar.value = Mathf.MoveTowards(_smoothHealthBar.value, _healthPlayer.NumberLives, _smoothSpeed * Time.deltaTime);
        }
    }
}