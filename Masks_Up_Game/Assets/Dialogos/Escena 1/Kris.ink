INCLUDE ../globals.ink

// Para comentar es Ctrl + "/" 
~casa = 0 
-> Kris

# RESET

#<b><color=\#FF1E35>cuarto</color></b>


=== Kris ===
~opcion("DifuminadoOn")
¿Qué haces en mi cuarto? #speaker:Kris #portrait:Kris #layout:left
* Buenos días! #speaker:Prota #portrait:Prota #layout:right
    No tienen nada de buenos. #speaker:Kris #portrait:Kris #layout:left
    -> Dialogo
* ¿Estás molesto? #speaker:Prota #portrait:Prota #layout:right
    No, y ahora vete, estoy ocupado. #speaker:Kris #portrait:Kris #layout:left
    -> Dialogo
* Quería hablar contigo. #speaker:Prota #portrait:Prota #layout:right
    No tengo tiempo, vete. #speaker:Kris #portrait:Kris #layout:left
    -> Dialogo
    

-> END

=== Dialogo ===

~reloj("Reloj2")
~ casa = casa + 1

Solo quería saber cómo estabas. #speaker:Prota #portrait:Prota #layout:right
Estoy bien cuando no te veo. #speaker:Kris #portrait:Kris #layout:left
* [Eres muy molesto.]
    Siempre eres igual, nos vemos. #speaker:Prota #portrait:Prota #layout:right
    ~reloj("Reloj1")
    ~opcion("DifuminadoOff")
    -> END
* [Perdón, me iré]
    Lamento molestar. #speaker:Prota #portrait:Prota #layout:right
    ~reloj("Reloj1")
    ~opcion("DifuminadoOff")
    -> END
* [...]
    Bueno, creo que me iré. #speaker:Prota #portrait:Prota #layout:right
    ~reloj("Reloj1")
    ~opcion("DifuminadoOff")
    -> END
-> END