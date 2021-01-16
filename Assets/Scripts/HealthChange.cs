using UnityEngine;
using UnityEngine.Events;

public class HealthChange : MonoBehaviour
{
    private float _variableValue = 10f;
    private float _maxHealth = 100f;
    private float _minHealth = 0f;
    private float _healthValue;

    public event UnityAction<float> HealthChanged;
    
    private void ChangeValue(float value)
    {
        float valueChange = _healthValue + value;

        if (valueChange >= _minHealth && valueChange <= _maxHealth)
        {
            _healthValue = valueChange;
            HealthChanged.Invoke(_healthValue);
        }
    }

    public void TakeDamage()
    {
        ChangeValue(_variableValue * -1);
    }

    public void Cure()
    {
        ChangeValue(_variableValue);
    }
}
