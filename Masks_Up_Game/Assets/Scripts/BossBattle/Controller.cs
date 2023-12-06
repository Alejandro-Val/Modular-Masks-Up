using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class Controller : MonoBehaviour
{
    int FaseCount = 0;
    int damage;

    bool InitFase1 = false;
    bool InitFase2 = false;
    bool InitFase3 = false;
    bool InitFase4 = false;
    bool InitFase5 = false;
    bool InitFase6 = false;

    public GameObject FondoFase1;
    public GameObject FondoFase2;
    public GameObject FondoFase3;
    public GameObject FondoFase4;
    public GameObject FondoFase5;
    public GameObject FondoFase6;

    public GameObject EnemigoFase1;
    public GameObject EnemigoFase2;
    public GameObject EnemigoFase3;
    public GameObject EnemigoFase4;
    public GameObject EnemigoFase5; 
    public GameObject EnemigoFase6;

    public GameObject DialogoArriba;
    public GameObject DialogoAbajo;

    public TextMeshProUGUI DialogoAbajoText = null;
    public TextMeshProUGUI DialogoArribaText = null;

    public GameObject Seleccion1;
    public GameObject Seleccion2;   
    public GameObject Seleccion3;

    public TextMeshProUGUI SelecText1 = null;
    public TextMeshProUGUI SelecText2 = null;
    public TextMeshProUGUI SelecText3 = null;

    public void FaseUpdate(){
        FaseCount = FaseCount + 1;
        switch(FaseCount){
            case 1:
                Fase1();
                break;
            case 2:
                Fase2();
                break;
            case 3:
                Fase3();
                break;
            case 4:
                Fase4();
                break;
            case 5:
                Fase5();
                break;
            case 6:
                Fase6();
                break;
        }
    }

    void Update(){
        if(InitFase1 == true){
            if(damage > 20){
                FaseUpdate();
            }
        }
        if(InitFase2 == true){
            if(damage > 20){
                FaseUpdate();
            }
        }
        if(InitFase3 == true){
            if(damage > 20){
                FaseUpdate();
            }
        }
        if(InitFase4 == true){
            if(damage > 20){
                FaseUpdate();
            }
        }
        if(InitFase5 == true){
            if(damage > 20){
                FaseUpdate();
            }
        }
        if(InitFase6 == true){
            if(damage > 20){
                FaseUpdate();
            }
        }
    }

    public void makeDamage(){
        damage = damage + 1;
    }

    public void Fase1(){
        InitFase1 = true;
        InitFase2 = false;
        InitFase3 = false;
        InitFase4 = false;
        InitFase5 = false;
        InitFase6 = false;
        damage = 0;
        FondoFase1.SetActive(true);
        EnemigoFase1.SetActive(true);
    }

    public void Fase2(){
        InitFase1 = false;
        InitFase2 = true;
        InitFase3 = false;
        InitFase4 = false;
        InitFase5 = false;
        InitFase6 = false;
        damage = 0;
        FondoFase2.SetActive(true);
        EnemigoFase2.SetActive(true);

        FondoFase1.SetActive(false);
        EnemigoFase1.SetActive(false);
    }

    public void Fase3(){
        InitFase1 = false;
        InitFase2 = false;
        InitFase3 = true;
        InitFase4 = false;
        InitFase5 = false;
        InitFase6 = false;
        damage = 0;
        FondoFase3.SetActive(true);
        EnemigoFase3.SetActive(true);

        FondoFase2.SetActive(false);
        EnemigoFase2.SetActive(false);
    }

    public void Fase4(){
        InitFase1 = false;
        InitFase2 = false;
        InitFase3 = false;
        InitFase4 = true;
        InitFase5 = false;
        InitFase6 = false;
        damage = 0;
        FondoFase4.SetActive(true);
        EnemigoFase4.SetActive(true);

        FondoFase3.SetActive(false);
        EnemigoFase3.SetActive(false);
    }

    public void Fase5(){
        InitFase1 = false;
        InitFase2 = false;
        InitFase3 = false;
        InitFase4 = false;
        InitFase5 = true;
        InitFase6 = false;
        damage = 0;
        FondoFase5.SetActive(true);
        EnemigoFase5.SetActive(true);

        FondoFase4.SetActive(false);
        EnemigoFase4.SetActive(false);
    }

    public void Fase6(){
        InitFase1 = false;
        InitFase2 = false;
        InitFase3 = false;
        InitFase4 = false;
        InitFase5 = false;
        InitFase6 = true;
        damage = 0;
        FondoFase6.SetActive(true);
        EnemigoFase6.SetActive(true);

        FondoFase5.SetActive(false);
        EnemigoFase5.SetActive(false);
    }
}
