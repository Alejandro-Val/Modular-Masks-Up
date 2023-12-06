using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class Menu : MonoBehaviour
{
    public int numeroEscena;
    public GameObject fondoPrincipal;
    public GameObject fondoOpciones;
    public GameObject fondoLogros;
    public GameObject fondoPerfil;
    public GameObject Login;
    public GameObject Singin;
    public GameObject LogrosInfo;
    public GameObject fondoPerfilPropio;
    public GameObject AdvertenciaPartidaNueva;	
    public GameObject AdvertenciaCerrarJuego;	
    public GameObject fondoNegro;
    public TextMeshProUGUI m_text = null;
    public TextMeshProUGUI gamertag_text = null;
    public GameObject TerminosYCondiciones;
    public GameObject Creditos; 
    [SerializeField] private AudioMixer audioMixer;

    [Header("Logros")]
    [SerializeField] public GameObject Logro1;
    [SerializeField] public GameObject Logro2;
    [SerializeField] public GameObject Logro3;
    [SerializeField] public GameObject Logro4;
    [SerializeField] public GameObject Logro5;
    [SerializeField] public GameObject Logro6;
    [SerializeField] public GameObject Logro7;
    [SerializeField] public GameObject Logro8;
    [SerializeField] public GameObject Logro9;
    [SerializeField] public GameObject Logro10;
    [SerializeField] public GameObject Logro11;
    [SerializeField] private int[] Logros = new int[10];

    IEnumerator DelayedFunctionOpciones()
    {
        yield return new WaitForSeconds(1);
    }

    public void cambiarEscena(){
        SceneManager.LoadScene(PlayerPrefs.GetString("DiaActual"));
    }

    public void AdvertenciaPartidaNuevaFuncion(){
        fondoNegro.SetActive(true);
        LeanTween.scaleX(AdvertenciaPartidaNueva, 1, 0.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scaleY(AdvertenciaPartidaNueva, 1, 0.5f).setEase(LeanTweenType.easeOutElastic);
    }

    public void DesactivarAdvertenciaPartidaNuevaFuncion(){
        fondoNegro.SetActive(false);
        LeanTween.scaleX(AdvertenciaPartidaNueva, 0, 0.5f).setEase(LeanTweenType.easeInOutExpo);
        LeanTween.scaleY(AdvertenciaPartidaNueva, 0, 0.5f).setEase(LeanTweenType.easeInOutExpo);
    }

    public void AdvertenciaCerrarJuegoFuncion(){
        fondoNegro.SetActive(true);
        LeanTween.scaleX(AdvertenciaCerrarJuego, 1, 0.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scaleY(AdvertenciaCerrarJuego, 1, 0.5f).setEase(LeanTweenType.easeOutElastic);
    }

    public void DesactivarAdvertenciaCerrarJuegoFuncion(){
        fondoNegro.SetActive(false);
        LeanTween.scaleX(AdvertenciaCerrarJuego, 0, 0.5f).setEase(LeanTweenType.easeInOutExpo);
        LeanTween.scaleY(AdvertenciaCerrarJuego, 0, 0.5f).setEase(LeanTweenType.easeInOutExpo);
    }

    public void PartidaNueva(){
        SceneManager.LoadScene(PlayerPrefs.GetString("DiaActual"));
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

    public void opciones(){
        LeanTween.scale(fondoPrincipal, new Vector2(3f,3f), 0.2f).setEase(LeanTweenType.easeOutSine).setOnComplete(opcionesActive);      
    }

    public void opcionesActive(){
        LeanTween.scale(fondoPrincipal, new Vector2(0f,0f), 0.0f).setEase(LeanTweenType.easeInSine);
        fondoOpciones.SetActive(true);
        LeanTween.scale(fondoOpciones, new Vector2(1f,1f), 0.2f).setEase(LeanTweenType.easeInSine);
    }

    public void logros(){
        LeanTween.scale(fondoPrincipal, new Vector2(3f,3f), 0.2f).setEase(LeanTweenType.easeOutSine).setOnComplete(logrosActive);
    }

    public void logrosActive(){
        LeanTween.scale(fondoPrincipal, new Vector2(0f,0f), 0.0f).setEase(LeanTweenType.easeInSine);
        ComprobarLogros();
        LogrosInfo.SetActive(false);
        fondoLogros.SetActive(true);
        LeanTween.scale(fondoLogros, new Vector2(1f,1f), 0.2f).setEase(LeanTweenType.easeInSine);
    }

    public void perfil(){
        LeanTween.scale(fondoPrincipal, new Vector2(3f,3f), 0.2f).setEase(LeanTweenType.easeOutSine).setOnComplete(perfilActive);
    }

    public void perfilActive()
    {
        LeanTween.scale(fondoPrincipal, new Vector2(0f,0f), 0.0f).setEase(LeanTweenType.easeInSine);
        if(gamertag_text.text != ""){
            fondoPerfilPropio.SetActive(true);
            LeanTween.scale(fondoPerfilPropio, new Vector2(1f,1f), 0.2f).setEase(LeanTweenType.easeInSine);
        }
        else{
            fondoPerfil.SetActive(true);
            LeanTween.scale(fondoPerfil, new Vector2(1f,1f), 0.2f).setEase(LeanTweenType.easeInSine);
            Login.SetActive(true); 
        }
    }
    
    public void IniciarSesion(){
        Singin.SetActive(false);
        Login.SetActive(true);
        m_text.text = "";
    }

    public void CrearCuenta(){
        Singin.SetActive(true);
        Login.SetActive(false);
        m_text.text = "";
    }

    public void volverLogros(){
        ComprobarLogros();
        LogrosInfo.SetActive(false);
        fondoLogros.SetActive(true);
        LeanTween.scale(fondoLogros, new Vector2(1f,1f), 0.5f).setEase(LeanTweenType.easeOutBounce);
    }

    public void volver(){
        if(fondoOpciones.activeSelf == true){
            LeanTween.scale(fondoOpciones, new Vector2(3f,3f), 0.2f).setEase(LeanTweenType.easeOutSine).setOnComplete(volverActive);
        }
        if(fondoLogros.activeSelf == true){
            LeanTween.scale(fondoLogros, new Vector2(3f,3f), 0.2f).setEase(LeanTweenType.easeOutSine).setOnComplete(volverActive);
        }
        if(fondoPerfil.activeSelf == true){
            LeanTween.scale(fondoPerfil, new Vector2(3f,3f), 0.2f).setEase(LeanTweenType.easeOutSine).setOnComplete(volverActive);
        }
        if(fondoPerfilPropio.activeSelf == true){
            LeanTween.scale(fondoPerfilPropio, new Vector2(3f,3f), 0.2f).setEase(LeanTweenType.easeOutSine).setOnComplete(volverActive);
        }
    }

    public void volverActive(){
        fondoOpciones.SetActive(false);
        fondoLogros.SetActive(false);
        fondoPerfil.SetActive(false);
        Singin.SetActive(false);
        Login.SetActive(false);
        fondoPerfilPropio.SetActive(false);

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

        m_text.text = "";

        LeanTween.scale(fondoPrincipal, new Vector2(1f,1f), 0.2f).setEase(LeanTweenType.easeInSine);
    }

    public void pantallaCompleta(bool pantallaCompleta){
        Screen.fullScreen = pantallaCompleta;
        if(pantallaCompleta == true){
            Debug.Log("PatallaCompleta");
        }
        else{
            Debug.Log("ModoVentana");
        }
    }

    public void CambiarVolumen(float volumen){
        audioMixer.SetFloat("Volumen", volumen);
    }

    public void showTerminosYCondiciones(){
        fondoNegro.SetActive(true);
        LeanTween.scale(TerminosYCondiciones, new Vector2(1f,1f), 0.2f).setEase(LeanTweenType.easeOutElastic);
    }

    public void hideTerminosYCondiciones(){
        fondoNegro.SetActive(false);
        LeanTween.scale(TerminosYCondiciones, new Vector2(0f,0f), 0.2f).setEase(LeanTweenType.easeInOutExpo);
    }

    public void showCreditos(){
        fondoNegro.SetActive(true);
        LeanTween.scale(Creditos, new Vector2(1f,1f), 0.2f).setEase(LeanTweenType.easeOutElastic);
    }

    public void hideCreditos(){
        fondoNegro.SetActive(false);
        LeanTween.scale(Creditos, new Vector2(0f,0f), 0.2f).setEase(LeanTweenType.easeInOutExpo);
    }

    public void ComprobarLogros(){
        Logros[0] = PlayerPrefs.GetInt("Logro1");
        if(Logros[0] > 0){
            Logro1.SetActive(true);
        }

        Logros[1] = PlayerPrefs.GetInt("Logro2");
        if(Logros[1] > 0){
            Logro2.SetActive(true);
        }
        
        Logros[2] = PlayerPrefs.GetInt("Logro3");
        if(Logros[2] > 0){
            Logro3.SetActive(true);
        }
        
        Logros[3] = PlayerPrefs.GetInt("Logro4");
        if(Logros[3] > 0){
            Logro4.SetActive(true);
        }
        
        Logros[4] = PlayerPrefs.GetInt("Logro5");
        if(Logros[4] > 0){
            Logro5.SetActive(true);
        }
        
        Logros[5] = PlayerPrefs.GetInt("Logro6");
        if(Logros[5] > 0){
            Logro6.SetActive(true);
        }
        
        Logros[6] = PlayerPrefs.GetInt("Logro7");
        if(Logros[6] > 0){
            Logro7.SetActive(true);
        }
        
        Logros[7] = PlayerPrefs.GetInt("Logro8");
        if(Logros[7] > 0){
            Logro8.SetActive(true);
        }
        
        Logros[8] = PlayerPrefs.GetInt("Logro9");
        if(Logros[8] > 0){
            Logro9.SetActive(true);
        }
        
        Logros[9] = PlayerPrefs.GetInt("Logro10");
        if(Logros[9] > 0){
            Logro10.SetActive(true);
        }
        
        Logros[10] = PlayerPrefs.GetInt("Logro11");
        if(Logros[10] > 0){
            Logro11.SetActive(true);
        }
        
    }

    public void salir(){
        Application.Quit();
        Debug.Log("aplicacion cerrada");
    }
}
