using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Slidertext : MonoBehaviour
{
    public TextMeshProUGUI textSlider;
    public Rigidbody rectSlider;

    void Start()
    {
        textSlider.text = rectSlider.transform.localScale.x.ToString("0.0");
    }

    public void textSlider_ValueChanged(float value)
    {
        textSlider.text = value.ToString("0.0");
    }
}
