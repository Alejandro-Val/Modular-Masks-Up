INCLUDE ../globals.ink

{flag:
    {cinta:
        -> completa
    - else:
        Vuelve a hablar conmigo cuando tengas la cinta. #speaker:Tito #portrait:Tito #layout:left
    }
 - else:
    -> inicio
}

=== inicio ===
¿Qué hay? ¿Necesitas algo? #speaker:Tito #portrait:Tito #layout:left
Un imán. #speaker:Prota #portrait:Prota #layout:right
Suena fácil, creo que lo puedo conseguir. Pero necesito un pequeño favor antes, consígueme cinta. #speaker:Tito #portrait:Tito #layout:left
Creo que podrías buscarla en la enfermería. No te preocupes por la maestra, le diré que fuiste al baño.
~opcion("DifuminadoOn")
Pero date prisa, tienes que regresar antes de que acabe la clase.
~flag = true
*[Suena bien]
    Claro que sí, soy un experto en los negocios bajos.
    ~opcion("DifuminadoOff")
    ~reloj("Reloj1")
    -> END
*[Suena mal]
    Ten un poco de fe, amigo mío.
    ~opcion("DifuminadoOff")
    ~reloj("Reloj1")
    -> END
*[No quiero]
    Bueno, te di una opción. Si la encuentras, tráela.
    ~opcion("DifuminadoOff")
    ~reloj("Reloj1")
    -> END

=== completa ===
Muy bien, la conseguiste. Un trato es un trato, aquí tienes el imán. #speaker:Tito #portrait:Tito #layout:left
~Max = true
-> END

=== incompleta ===
Vuelve a hablar conmigo cuando tengas la cinta. #speaker:Tito #portrait:Tito #layout:left
-> END
