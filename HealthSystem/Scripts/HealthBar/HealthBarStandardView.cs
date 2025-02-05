using UnityEngine.UI;

public class HealthBarStandardView : HealthBarView<Slider>
{
    protected override void ChangeHealth()
    {
        if (Bar != null)
        {
            Bar.value = Health.Number;
        }
    }
}
