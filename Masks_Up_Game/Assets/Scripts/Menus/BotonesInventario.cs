using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesInventario : MonoBehaviour
{
    public GameObject BotonActivar;
    public GameObject BotonDesactivar;
    public GameObject Inventario;

    public void Show(){
        BotonActivar.SetActive(false);
        BotonDesactivar.SetActive(true);
        Inventario.SetActive(true);
    }

    public void Hide(){
        BotonActivar.SetActive(true);
        BotonDesactivar.SetActive(false);
        Inventario.SetActive(false);
    }
}
