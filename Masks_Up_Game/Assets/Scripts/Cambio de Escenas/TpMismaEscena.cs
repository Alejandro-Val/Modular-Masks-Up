using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpMismaEscena : MonoBehaviour
{
    public DeteccionDeColision boton;
    public Vector2 newPosition;
    public GameObject player;
    public Camera mainCamera;
    public Camera secondCamera;
    public Animator animacion; 

    void Start()
    {

    }

    private void Update() {
        if(boton.flag == true){
            tp();
        }
    }


    public void tp()
    {
        StartCoroutine("Esperar");
    }
    IEnumerator Esperar(){
        animacion.SetBool("Off",true);
        yield return new WaitForSeconds(.5f);
        player.transform.position = newPosition;
        mainCamera.enabled = false;
        secondCamera.enabled = true;
        animacion.SetBool("Off",false);

    }
}
