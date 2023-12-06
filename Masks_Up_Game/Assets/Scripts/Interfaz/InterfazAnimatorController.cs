using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfazAnimatorController : MonoBehaviour
{
    public GameObject inventario;
    public GameObject botonInventario;
    public GameObject botonPausa;
    public GameObject menuPausa;
    public GameObject blocPausa;
    public GameObject TextoTransicion;
    public GameObject player;

    private bool active = false;
    private bool pause = false;
    private bool Joystick = false;

    void Start()
    {
        LeanTween.scale(TextoTransicion.GetComponent<RectTransform>(), new Vector3(2, 2, 2), 3.0f).setEase(LeanTweenType.easeInOutSine);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)){
            MostrarInventario();
        }
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(pause == false){
                PausarJuego(); 
            }
            else{
                ReanudarJuego();
            }
        }
    }

    public void MostrarInventario(){
        if(active == false){
            LeanTween.moveY(inventario.GetComponent<RectTransform>(), 390, 0.2f).setEase(LeanTweenType.easeOutElastic);
            LeanTween.moveY(botonInventario.GetComponent<RectTransform>(), 18, 0.2f);
            LeanTween.scale(botonInventario.GetComponent<RectTransform>(), new Vector3(1, -1, 1), 0.2f);
            active = true;
        }
        else{
            LeanTween.moveY(inventario.GetComponent<RectTransform>(), -31, 0.2f);
            LeanTween.moveY(botonInventario.GetComponent<RectTransform>(), 0f, 0.2f);
            LeanTween.scale(botonInventario.GetComponent<RectTransform>(), new Vector3(1, 1, 1), 0.2f);
            active = false;
        }
    }

    public void OpcionesPausa(){
        menuPausa.SetActive(false);
    }

    public void CerrarOpcionesPausa(){
        menuPausa.SetActive(true);
    }

    public void PausarJuego(){
        blocPausa.SetActive(true);
        LeanTween.moveX(menuPausa.GetComponent<RectTransform>(), 115, 0.2f).setOnComplete(SetTime);
        if(player.GetComponent<MovimientoTopDown>().enabled == false){
            player.GetComponent<MovimientoJoystick>().enabled = false;
            Joystick = true;
        }
        else{
            player.GetComponent<MovimientoTopDown>().enabled = false;
        }
    }

    public void ReanudarJuego(){
        Time.timeScale = 1f;
        blocPausa.SetActive(false);
        LeanTween.moveX(menuPausa.GetComponent<RectTransform>(), -118, 0.2f).setOnComplete(setFalse);
        if(Joystick == true){
            player.GetComponent<MovimientoJoystick>().enabled = true;
        }
        else{
            player.GetComponent<MovimientoTopDown>().enabled = true;
        }
    }

    public void SetTime(){
        Time.timeScale = 0f;
        pause = true;
    }

    public void setFalse(){
        pause = false;
    }
}
