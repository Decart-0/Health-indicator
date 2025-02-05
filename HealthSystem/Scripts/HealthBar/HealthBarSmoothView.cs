using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmoothView : HealthBarView<Slider>
{
    [SerializeField] private float _smoothSpeed;

    private void Update()
    {
        if (Bar != null)
        {
            Bar.value = Mathf.MoveTowards(Bar.value, Health.Number, _smoothSpeed * Time.deltaTime);
        }
    }
}
