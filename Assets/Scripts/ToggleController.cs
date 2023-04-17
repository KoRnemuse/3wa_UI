using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleController : MonoBehaviour
{
    private bool _isOn;
    public void OnValueChanged(bool newValue)
    {
        _isOn = newValue;
        Debug.Log(_isOn);
    }
}
