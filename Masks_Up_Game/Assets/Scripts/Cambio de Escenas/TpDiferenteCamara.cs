using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpDiferenteCamara : MonoBehaviour
{
    public DeteccionDeColision boton;
    public Vector2 newPosition;
    public GameObject player;
    public Camera cameraToActivate;
    public Animator animacion; 

    void Start()
    {

    }

    private void Update() {
        if(boton.flag == true){
            tp();
        }
    }

    IEnumerator Esperar(){
        animacion.SetBool("Off",true);
        yield return new WaitForSeconds(.5f);
        player.transform.position = newPosition;
        // Desactiva todas las cámaras
        Camera[] allCameras = Camera.allCameras;
        foreach (Camera camera in allCameras)
        {
            camera.enabled = false;
            
        }
        // Activa la nueva cámara
        cameraToActivate.enabled = true;
        animacion.SetBool("Off",false);

    }

    public void tp(){
        StartCoroutine("Esperar");
    }
}
