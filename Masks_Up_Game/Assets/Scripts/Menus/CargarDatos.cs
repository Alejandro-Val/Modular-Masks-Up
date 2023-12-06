using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class CargarDatos : MonoBehaviour
{
    [Header("Informacion")]
    [SerializeField] private TextMeshProUGUI gamertag_text = null;
    [SerializeField] private TextMeshProUGUI nombre = null;
    [SerializeField] private TextMeshProUGUI playTimeText = null;
    [SerializeField] private TextMeshProUGUI diagnosisText = null;

    [SerializeField] private int[] Logros = new int[10];

    void Start()
    {
        gamertag_text.text = PlayerPrefs.GetString("NombreUsuario");
        nombre.text = PlayerPrefs.GetString("NombreUsuario");
        diagnosisText.text = PlayerPrefs.GetString("diagnosis");
        float playTime = PlayerPrefs.GetFloat("PlayTime", 0f);

        int hours = Mathf.FloorToInt(playTime / 3600);
        int minutes = Mathf.FloorToInt((playTime - hours * 3600) / 60);
        int seconds = Mathf.FloorToInt(playTime - hours * 3600 - minutes * 60);
        playTimeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);

        ComprobarLogros();
    }

    public void ComprobarLogros(){
        PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia1");
        Logros[0] = PlayerPrefs.GetInt("Logro1");
        if(Logros[0] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia2");
        }

        Logros[1] = PlayerPrefs.GetInt("Logro2");
        if(Logros[1] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia3");
        }
        
        Logros[2] = PlayerPrefs.GetInt("Logro3");
        if(Logros[2] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia4");
        }
        
        Logros[3] = PlayerPrefs.GetInt("Logro4");
        if(Logros[3] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia5");
        }
        
        Logros[4] = PlayerPrefs.GetInt("Logro5");
        if(Logros[4] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia6");
        }
        
        Logros[5] = PlayerPrefs.GetInt("Logro6");
        if(Logros[5] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia7");
        }
        
        Logros[6] = PlayerPrefs.GetInt("Logro7");
        if(Logros[6] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia8");
        }
        
        Logros[7] = PlayerPrefs.GetInt("Logro8");
        if(Logros[7] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia9");
        }
        
        Logros[8] = PlayerPrefs.GetInt("Logro9");
        if(Logros[8] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia10");
        }
        
        Logros[9] = PlayerPrefs.GetInt("Logro10");
        if(Logros[9] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia11");
        }
    }
}