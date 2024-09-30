using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI text;

    // Update is called once per frame
    void FixedUpdate()
    {
        text.text = Time.time.ToString("00.0");
    }
}
