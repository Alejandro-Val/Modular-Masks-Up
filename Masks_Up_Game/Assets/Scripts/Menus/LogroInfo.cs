using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class LogroInfo : MonoBehaviour
{
    public GameObject CuadroLogro1;
    public GameObject CuadroLogro2;
    public GameObject CuadroLogro3;
    public GameObject CuadroLogro4;
    public GameObject CuadroLogro5;
    public GameObject CuadroLogro6;
    public GameObject CuadroLogro7;
    public GameObject CuadroLogro8;
    public GameObject CuadroLogro9;
    public GameObject CuadroLogro10;
    public GameObject CuadroLogro11;

    public GameObject Logro1;
    public GameObject Logro2;
    public GameObject Logro3;
    public GameObject Logro4;
    public GameObject Logro5;
    public GameObject Logro6;
    public GameObject Logro7;
    public GameObject Logro8;
    public GameObject Logro9;
    public GameObject Logro10;
    public GameObject Logro11;
    public GameObject LogrosInfo;

    public int logroActual = 0;

    public void desactivacion(){
        Logro1.SetActive(false);
        Logro2.SetActive(false);
        Logro3.SetActive(false);
        Logro4.SetActive(false);
        Logro5.SetActive(false);
        Logro6.SetActive(false);
        Logro7.SetActive(false);
        Logro8.SetActive(false);
        Logro9.SetActive(false);
        Logro10.SetActive(false);
        Logro11.SetActive(false);

        CuadroLogro1.SetActive(false);
        CuadroLogro2.SetActive(false);
        CuadroLogro3.SetActive(false);
        CuadroLogro4.SetActive(false);
        CuadroLogro5.SetActive(false);
        CuadroLogro6.SetActive(false);
        CuadroLogro7.SetActive(false);
        CuadroLogro8.SetActive(false);
        CuadroLogro9.SetActive(false);
        CuadroLogro10.SetActive(false);
        CuadroLogro11.SetActive(false);

        if(logroActual == 1){
            Logro1.SetActive(true);
            animacionPaso2();
        }
        if(logroActual == 2){
            Logro2.SetActive(true);
            animacionPaso2();
        }
        if(logroActual == 3){
            Logro3.SetActive(true);
            animacionPaso2();
        }
        if(logroActual == 4){
            Logro4.SetActive(true);
            animacionPaso2();
        }
        if(logroActual == 5){
            Logro5.SetActive(true);
            animacionPaso2();
        }
        if(logroActual == 6){
            Logro6.SetActive(true);
            animacionPaso2();
        }
        if(logroActual == 7){
            Logro7.SetActive(true);
            animacionPaso2();
        }
        if(logroActual == 8){
            Logro8.SetActive(true);
            animacionPaso2();
        }
        if(logroActual == 9){
            Logro9.SetActive(true);
            animacionPaso2();
        }
        if(logroActual == 10){
            Logro10.SetActive(true);
            animacionPaso2();
        }
        if(logroActual == 11){
            Logro11.SetActive(true);
            animacionPaso2();
        }
    }

    public void animacionPaso1(){
        LogrosInfo.SetActive(true);
        LeanTween.scale(LogrosInfo, new Vector2(0f,0f), 0.0f).setOnComplete(desactivacion);
    }

    public void animacionPaso2(){
        LeanTween.scale(LogrosInfo, new Vector2(1f,1f), 0.5f).setEase(LeanTweenType.easeOutBounce);
    }

    public void ShowLogro1(){
        logroActual = 1; 
        animacionPaso1();
    }

    public void ShowLogro2(){
        logroActual = 2; 
        animacionPaso1();
    }

    public void ShowLogro3(){
        logroActual = 3; 
        animacionPaso1();
    }

    public void ShowLogro4(){
        logroActual = 4; 
        animacionPaso1();
    }

    public void ShowLogro5(){
        logroActual = 5; 
        animacionPaso1();
    }

    public void ShowLogro6(){
        logroActual = 6; 
        animacionPaso1();
    }

    public void ShowLogro7(){
        logroActual = 7; 
        animacionPaso1();
    }

    public void ShowLogro8(){
        logroActual = 8; 
        animacionPaso1();
    }

    public void ShowLogro9(){
        logroActual = 9; 
        animacionPaso1();
    }

    public void ShowLogro10(){
        logroActual = 10; 
        animacionPaso1();
    }

    public void ShowLogro11(){
        logroActual = 11; 
        animacionPaso1();
    }

}
