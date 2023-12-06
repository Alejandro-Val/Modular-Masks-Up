using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpHabitacion : MonoBehaviour
{
    public DeteccionDeColision boton;
    public Vector2 newPosition;
    public GameObject player;
    public Animator animacion; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(boton.flag == true){
            
            tp();
            
        }
    }

    IEnumerator Esperar(){
        animacion.SetBool("Off",true);
        yield return new WaitForSeconds(.5f);
        player.transform.position = newPosition;
        animacion.SetBool("Off",false);

    }

    public void tp(){
        StartCoroutine("Esperar");
    }
}
