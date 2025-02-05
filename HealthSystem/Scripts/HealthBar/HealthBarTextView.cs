using TMPro;

public class HealthBarTextView : HealthBarView<TMP_Text>
{
    private const string CharacterSeparator = "/";
   
    protected override void ChangeHealth()
    {
        if (Bar != null)
        {
            Bar.text = $"{Health.Number}{CharacterSeparator}{Health.MaxNumber}";
        }
    }
}