using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class InventarioController : MonoBehaviour
{
    void Start()
    {
        ComprobarItems();
    }

    [Header("Descripcion")]
    public TextMeshProUGUI nombreItem = null;
    public TextMeshProUGUI DescripcionItem = null;

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
    [SerializeField] private int[] Logros = new int[10];

    public void ComprobarItems(){
        Logros[0] = PlayerPrefs.GetInt("Logro1");
        Debug.Log(Logros[0]);
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
    }

    public void CheckLogro1(){
        if(Logros[0] > 0){
            nombreItem.text = "Collar de media luna";
            DescripcionItem.text = "Este collar con forma de media luna parece tener un gran valor sentimental para alguien, como si hubiera sido impregnado con emociones y recuerdos profundos. Además, su diseño sugiere que podría ser parte de un conjunto más grande, tal vez encajando con otro collar del mismo estilo";
        }
        else{
            nombreItem.text = "???";
            DescripcionItem.text = "???";
        }
    }

    public void CheckLogro2(){
        if(Logros[1] > 0){
            nombreItem.text = "Collar de sol";
            DescripcionItem.text = "Este collar en forma de sol es una muestra de gran artesanía. Sin embargo, a diferencia de su contraparte en forma de media luna, parece haber sido impregnado con emociones oscuras y negativas. Aunque no encaja perfectamente con el collar en forma de media luna juntos representan la dualidad de la luz y la oscuridad, y la lucha constante entre ellas";
        }
        else{
            nombreItem.text = "???";
            DescripcionItem.text = "???";
        }
    }

    public void CheckLogro3(){
        if(Logros[2] > 0){
            nombreItem.text = "Celular gótico";
            DescripcionItem.text = "Este celular gótico parece ser un modelo muy antiguo que ya no es compatible con las últimas aplicaciones y funciones en línea. Sin embargo, su cámara parece estar en perfecto estado, podría aprovecharse de alguna manera";
        }
        else{
            nombreItem.text = "???";
            DescripcionItem.text = "???";
        }
    }

    public void CheckLogro4(){
        if(Logros[3] > 0){
            nombreItem.text = "Dinero";
            DescripcionItem.text = "Este dinero parece haber sido recaudado de maneras poco confiables y posiblemente proviene de estafas hacia otros estudiantes de la escuela. A pesar de su origen cuestionable, en las manos correctas podría ser utilizado de manera ética y para un buen propósito";
        }
        else{
            nombreItem.text = "???";
            DescripcionItem.text = "???";
        }
    }

    public void CheckLogro5(){
        if(Logros[4] > 0){
            nombreItem.text = "Llavero de juego indie";
            DescripcionItem.text = "Este llavero es una pieza de colección de un juego indie clásico, considerado por muchos fans del videojuego como algo irremplazable. Su diseño detallado y la calidad de sus materiales lo convierten en una verdadera joya para los coleccionistas";
        }
        else{
            nombreItem.text = "???";
            DescripcionItem.text = "???";
        }
    }

    public void CheckLogro6(){
        if(Logros[5] > 0){
            nombreItem.text = "Llave maestra";
            DescripcionItem.text = "Esta llave maestra parece haber sido robada de la oficina del director, y tiene la capacidad de abrir cualquier puerta de la escuela. Esto parece ser útil para salir de la escuela, es importante tener en cuenta que su posesión ilegal podría acarrear graves consecuencias";
        }
        else{
            nombreItem.text = "???";
            DescripcionItem.text = "???";
        }
    }

    public void CheckLogro7(){
        if(Logros[6] > 0){
            nombreItem.text = "Libro de consejos";
            DescripcionItem.text = "Este libro de consejos fue escrito por la reconocida doctora Alejandra López, una especialista en hacerle cosquillas a la vida. En sus páginas, el lector encontrará una gran cantidad de consejos y reflexiones que lo ayudarán a liberarse de cualquier preocupación en su vida";
        }
        else{
            nombreItem.text = "???";
            DescripcionItem.text = "???";
        }
    }

    public void CheckLogro8(){
        if(Logros[7] > 0){
            nombreItem.text = "Peluche de consuelo";
            DescripcionItem.text = "Este peluche de consuelo tiene la forma de una ranita y está diseñado para recordarte los buenos momentos que has tenido. A pesar de su origen modesto (se dice que fue sacado de una feria local), este peluche tiene un gran valor sentimental para quienes lo poseen";
        }
        else{
            nombreItem.text = "???";
            DescripcionItem.text = "???";
        }
    }

    public void CheckLogro9(){
        if(Logros[8] > 0){
            nombreItem.text = "Carta de margarita";
            DescripcionItem.text = "Esta carta de margarita fue entregada hace mucho tiempo con la intención de arreglar la situación entre ustedes y Noé. De ti depende como termine esta historia";
        }
        else{
            nombreItem.text = "???";
            DescripcionItem.text = "???";
        }
    }

    public void CheckLogro10(){
        if(Logros[9] > 0){
            nombreItem.text = "Foto vieja";
            DescripcionItem.text = "Esta es una simple foto, pero algo extraño parece suceder con ella. Algo te impide verla con claridad, ¿te recuerda a algo?";
        }
        else{
            nombreItem.text = "???";
            DescripcionItem.text = "???";
        }
    }
}
