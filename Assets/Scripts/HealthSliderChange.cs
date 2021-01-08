﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthSliderChange : MonoBehaviour
{
    private float _variableValue = 1;
    private Slider _slider;

    private void Start()
    {
        _slider = gameObject.GetComponent<Slider>();
    }

    private void ChangeValue(float value)
    {
        float valueChange = _slider.value + value;

        if(valueChange <= _slider.maxValue & valueChange >= _slider.minValue)
        {
            _slider.DOValue(valueChange, 1);
        }

    }

    public void ReduceHealth()
    {
        ChangeValue(_variableValue * -1);
    }

    public void IncreaseHealth()
    {
        ChangeValue(_variableValue);
    }
}
