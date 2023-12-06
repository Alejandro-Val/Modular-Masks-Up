using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Ink.Runtime;
using UnityEngine.Playables;

public class InkExternalFunctions
{
    public int ansiedad = 0;
    public int depresion = 0;
    public int deficit = 0;
    public void Bind(Story story, PlayableDirector director)
    {
        story.BindExternalFunction("ansiedad",Ansiedad);
        story.BindExternalFunction("depresion",Depresion);
        story.BindExternalFunction("deficit",Deficit);
        story.BindExternalFunction("cambiarEscena", (string nombreDeEscena) => CambiarEscena(nombreDeEscena));
        story.BindExternalFunction("pausa", () => Pausa(director));
    }

    public void Unbind(Story story) 
    {
        story.UnbindExternalFunction("ansiedad");
        story.UnbindExternalFunction("depresion");
        story.UnbindExternalFunction("deficit");
        story.UnbindExternalFunction("cambiarEscena");
        story.UnbindExternalFunction("pausa");
    }

    public void Ansiedad()
    {
        ansiedad++;
        return;
    }

    public void Depresion()
    {
        depresion++;
        return;
    }

    public void Deficit()
    {
        deficit++;
        return;
    }

    public void CambiarEscena(string nombreDeEscena)
    {
        SceneManager.LoadScene(nombreDeEscena);
    }

    public void Pausa(PlayableDirector director)
    {
            if (director.state == PlayState.Playing)
            {
                // Pausar la timeline si está en reproducción.
                director.Pause();
            }
            else if (director.state == PlayState.Paused)
            {
                // Reanudar la timeline si está pausada.
                director.Resume();
            }
    }

    
}
