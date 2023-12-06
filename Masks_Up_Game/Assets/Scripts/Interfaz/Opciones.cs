using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class Opciones : MonoBehaviour
{
    public GameObject AdvertenciaReinicio;
    public GameObject AdvertenciaMenuPrincipal;
    public GameObject fondoNegro;

    public void ReiniciarDia(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void MenuPrincipal(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void MostrarAdvertenciaReinicio(){
        fondoNegro.SetActive(true);
        Time.timeScale = 1f;
        LeanTween.scaleX(AdvertenciaReinicio, 1, 0.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scaleY(AdvertenciaReinicio, 1, 0.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(SetTime);
    }

    public void DesactivarAdvertenciaReinicio(){
        fondoNegro.SetActive(false);
        Time.timeScale = 1f;
        LeanTween.scaleX(AdvertenciaReinicio, 0, 0.5f).setEase(LeanTweenType.easeInOutExpo);
        LeanTween.scaleY(AdvertenciaReinicio, 0, 0.5f).setEase(LeanTweenType.easeInOutExpo).setOnComplete(SetTime);
    }

    public void MostrarAdvertenciaMenuPrincipal(){
        fondoNegro.SetActive(true);
        Time.timeScale = 1f;
        LeanTween.scaleX(AdvertenciaMenuPrincipal, 1, 0.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scaleY(AdvertenciaMenuPrincipal, 1, 0.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(SetTime);
    }

    public void DesactivarAdvertenciaMenuPrincipal(){
        fondoNegro.SetActive(false);
        Time.timeScale = 1f;
        LeanTween.scaleX(AdvertenciaMenuPrincipal, 0, 0.5f).setEase(LeanTweenType.easeInOutExpo);
        LeanTween.scaleY(AdvertenciaMenuPrincipal, 0, 0.5f).setEase(LeanTweenType.easeInOutExpo).setOnComplete(SetTime);
    }

    public void SetTime(){
        Time.timeScale = 0f;
    }
}
