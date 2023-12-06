using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public DeteccionDeColision boton;
    private Animator animacion;
    [SerializeField] private AnimationClip animacionFinal;
    public string nombreDeEscena;
    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    void Update()
    {
        if (boton.flag == true)
        {
            CambioDeEscena();
        }

    }

    IEnumerator CambiarEscena(){
        animacion.SetTrigger("Inicio");
        yield return new WaitForSeconds(animacionFinal.length);
    }
    
    public void CambioDeEscena(){
        StartCoroutine(CambiarEscena());
        SceneManager.LoadScene(nombreDeEscena);
    }

}
