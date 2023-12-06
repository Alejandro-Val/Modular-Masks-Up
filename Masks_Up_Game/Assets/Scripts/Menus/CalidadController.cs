using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalidadController : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    void Start()
    {
        int calidad = PlayerPrefs.GetInt("calidad");
        dropdown.value = calidad;
    }
    
    void Update()
    {
        int value = dropdown.value;
        PlayerPrefs.SetInt("calidad", value);
    }
}
