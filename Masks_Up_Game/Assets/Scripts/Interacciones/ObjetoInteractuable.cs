using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjetoInteractuable : MonoBehaviour
{
    public MovimientoTopDown movimiento;
    public TextMeshProUGUI texto;
    [TextArea(1,3)]
    public string[] parrafos;
    int index;
    public float velParrafo;
    public LayerMask personaje; //Mascara para interactuar con el personaje
    public GameObject botonInteractivo; //Boton Interactuar
    public GameObject Panel; //  Panel de Dialogo
    public GameObject Continuar; //Boton continuar
    public GameObject Terminar; //Boton quitar

    private void Start()
    {
        botonInteractivo.gameObject.SetActive(false);
        Panel.gameObject.SetActive(false);
        Continuar.gameObject.SetActive(false);
        Terminar.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (texto.text == parrafos[index])
        {
            Continuar.SetActive(true);
        }

        if (botonInteractivo.activeInHierarchy == true & Input.GetKeyDown(KeyCode.E))
        {
            activarMostrarInformacion();
        }

        if (Continuar.activeInHierarchy == true & Input.GetKeyDown(KeyCode.E))
        {
            siguienteParrafo();
        }
        if (Terminar.activeInHierarchy == true & Input.GetKeyDown(KeyCode.E))
        {
            botonCerrar();
        }
    }

    IEnumerator textDialogo()
    {
        foreach (char letra in parrafos[index].ToCharArray())
        {
            texto.text += letra;
            yield return new WaitForSeconds(velParrafo);
        }
    }

    public void siguienteParrafo()
    {
        Continuar.SetActive(true);
        if(index < parrafos.Length - 1)
        {
            index++;
            texto.text= "";
            StartCoroutine(textDialogo());
        }
        else
        {
            texto.text="...";
            Continuar.SetActive(false);
            Terminar.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        botonInteractivo.gameObject.SetActive(true);
    }


    private void OnCollisionExit2D(Collision2D other)
    {
        botonInteractivo.gameObject.SetActive(false);
        Panel.gameObject.SetActive(false);
        Continuar.SetActive(false);
        Terminar.SetActive(false);
        texto.text= "";
        index = 0;
    }

    public void activarMostrarInformacion()
    {
        botonInteractivo.SetActive(false);
        Panel.gameObject.SetActive(true);
        movimiento.velocidadMovimiento = 0;
        StartCoroutine(textDialogo());
    }
    public void botonCerrar()
    {
        botonInteractivo.SetActive(false);
        Panel.SetActive(false);
        movimiento.velocidadMovimiento = 2;
        Terminar.gameObject.SetActive(true);
    }



}
