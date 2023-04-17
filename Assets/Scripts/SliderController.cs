using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textmesh;
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _textmesh.text = _slider.value.ToString();
        
    }
    public void OnSliderValueChanged(float value)
    {
        _textmesh.text = value.ToString();
    }

}
