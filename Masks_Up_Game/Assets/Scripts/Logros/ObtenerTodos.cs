using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerTodos : MonoBehaviour
{
    public void DarLogros(){
        PlayerPrefs.SetInt("Logro1", 1);
        PlayerPrefs.SetInt("Logro2", 1);
        PlayerPrefs.SetInt("Logro3", 1);
        PlayerPrefs.SetInt("Logro4", 1);
        PlayerPrefs.SetInt("Logro5", 1);
        PlayerPrefs.SetInt("Logro6", 1);
        PlayerPrefs.SetInt("Logro7", 1);
        PlayerPrefs.SetInt("Logro8", 1);
        PlayerPrefs.SetInt("Logro9", 1);
        PlayerPrefs.SetInt("Logro10", 1);
        PlayerPrefs.SetInt("Logro11", 1);
    }

    public void QuitarLogros(){
        PlayerPrefs.SetInt("Logro1", 0);
        PlayerPrefs.SetInt("Logro2", 0);
        PlayerPrefs.SetInt("Logro3", 0);
        PlayerPrefs.SetInt("Logro4", 0);
        PlayerPrefs.SetInt("Logro5", 0);
        PlayerPrefs.SetInt("Logro6", 0);
        PlayerPrefs.SetInt("Logro7", 0);
        PlayerPrefs.SetInt("Logro8", 0);
        PlayerPrefs.SetInt("Logro9", 0);
        PlayerPrefs.SetInt("Logro10", 0);
        PlayerPrefs.SetInt("Logro11", 0);
    }
}
