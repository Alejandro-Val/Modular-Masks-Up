using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PantallaController : MonoBehaviour
{
    public Toggle toggle;

    void Start()
    {
        int toggleState = PlayerPrefs.GetInt("ToggleState");
        bool estado;
        if(toggleState == 1){
            estado = true;
        }
        else{
            estado = false;
        }
        toggle.isOn = estado;
    }
    
    void Update()
    {
        bool selected = toggle.isOn;
        int opc;
        if(selected == true){
            opc = 1;
        }
        else{
            opc = 0;
        }
        PlayerPrefs.SetInt("ToggleState", opc);
    }
}
