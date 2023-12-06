INCLUDE ../globals.ink

~bandera = false
Dejame en paz, estoy enseñandole una lección a Viernes. #speaker:Maximiliano #portrait:Maximiliano #layout:left
Claro que no, solo me estás molestando como todos los días. #speaker:Viernes #portrait:Viernes #layout:right
~opcion("DifuminadoOn")
Vete si no quieres ser el siguiente. #speaker:Maximiliano #portrait:Maximiliano #layout:left
*Le hablaré a un maestro. #speaker:Prota #portrait:Prota #layout:right
    ~ bandera = true
    Jajaja, parece que de verdad quieres problemas. #speaker:Maximiliano #portrait:Maximiliano #layout:left
    A nadie le importa este mequetrefe, así que haz lo que quieras.
    ->fin
*Déjalo en paz. #speaker:Prota #portrait:Prota #layout:right
    ~ bandera = true
    Vaya, tenemos a un héroe por aquí. #speaker:Maximiliano #portrait:Maximiliano #layout:left
    Después de clase me encargaré de ti, te tocará lo mismo que a Viernes si tanto quieres.
    ->fin
*No es problema mío #speaker:Prota #portrait:Prota #layout:right
    ~ bandera = false
    Eso imaginé, ahora largo. #speaker:Maximiliano #portrait:Maximiliano #layout:left
    ->fin
    
=== fin ===

~escuela = true
~opcion("DifuminadoOff")
~reloj("Reloj0")

->END