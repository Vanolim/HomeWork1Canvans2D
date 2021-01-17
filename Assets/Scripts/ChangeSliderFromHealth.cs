using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ChangeSliderFromHealth : MonoBehaviour
{
    [SerializeField] private HealthChange _healthValue;

    private Slider _slider;

    private void Start()
    {
        _slider = gameObject.GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _healthValue.HealthChanged += ChangeValue;
    }

    private void OnDisable()
    {
        _healthValue.HealthChanged -= ChangeValue;
    }

    private void ChangeValue(float value)
    {
        _slider.DOValue(value, 1);
    }
}
