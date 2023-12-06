using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumenController : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        float volumen = PlayerPrefs.GetFloat("volumen");
        slider.value = volumen;
    }
    
    void Update()
    {
        float value = slider.value;
        PlayerPrefs.SetFloat("volumen", value);
    }
}
