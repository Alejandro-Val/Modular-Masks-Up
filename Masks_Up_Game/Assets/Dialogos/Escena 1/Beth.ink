INCLUDE ../globals.ink

{casa == 1:
	->inicio
- else:
    {casa == 2:
        Hora de ir a la escuela, con cuidado  #speaker:Beth #portrait:Beth #layout:left
    - else: 
        Dile a tu hermano que baje por favor cielo. #speaker:Beth #portrait:Beth #layout:left
    }
}


=== inicio ===

Buenos dias, ¿Ya saludaste a tu hermano? #speaker:Beth #portrait:Beth #layout:left
* [Sí, pasé por su cuarto] No parecía de buenas. #speaker:Prota #portrait:Prota #layout:right
    --Bueno, ya sabes como es el.. ha cambiado mucho. #speaker:Beth #portrait:Beth #layout:leftS
    ~opcion("DifuminadoOn")
    -> Decision
* [No estaba de buenas] Parece que no quieren que lo molesnten. #speaker:Prota #portrait:Prota #layout:right
    --Mejor así, se la pasan discutiendo todo el tiempo.. #speaker:Beth #portrait:Beth #layout:left
    ~opcion("DifuminadoOn")
    -> Decision

    

=== Decision ===
-Extraño los tiempos de antes #speaker:Beth #portrait:Beth #layout:left
* [¿Todo está bien?]
    --¿Puedo ayudar con algo? #speaker:Prota #portrait:Prota #layout:right
    --Oh, perdón, estaba hablando conmigo misma. #speaker:Beth #portrait:Beth #layout:left
    -> Noe
* [Por culpa de mi hermano.]
    -- Yo también espero que pueda cambiar pronto. #speaker:Prota #portrait:Prota #layout:right
    --Tú también debes poner de tu parte, cariño. #speaker:Beth #portrait:Beth #layout:left
    -> Noe
* [Vi tus dibujos.]
    --Deberías dibujar de nuevo, madre, eso te relajaba. #speaker:Prota #portrait:Prota #layout:right
    --No sé dónde tengo la mente, pero no es en los dibujos, cielo. #speaker:Beth #portrait:Beth #layout:left
    -> Noe

-> Noe
 
=== Noe ===
~reloj("Reloj0")
~opcion("DifuminadoOff")

Pero mira la hora. ¿No deberías ir a la escuela?#speaker:Beth #portrait:Beth #layout:left
~ casa = casa + 1
Si ves a Noé, salúdalo de mi parte.
* [¿Noé?]
    --¿Por qué hablas como si no lo conocieras? ¡Es tu mejor amigo! Vive en la casa roja de camino a la escuela.
    -- Se te hará más tarde, vete con cuidado, cielo.
    -> END
* [Ah, claro, pasaré por su casa]
    -- Con cuidado, cielo.
    -> END
    

