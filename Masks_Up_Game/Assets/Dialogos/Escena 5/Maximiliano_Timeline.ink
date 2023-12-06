INCLUDE ../globals.ink

 #speaker:Maximiliano #portrait:Maximiliano #layout:right
{bandera:
    Hey, tu.
    Aun tengo asuntos pendientes contigo.
  - else:
    Mira bien infeliz.
    ¿Quien te creiste al ignorarme?
}

~flag = false
~cinta = false
~Max = false
~escuela = false
~calle = false
~casa = 0


¿Se puede saber que haces? #speaker:Maxine #portrait:Maxine #layout:left

Que!? Maxine? Crei que ya te habias ido. #speaker:Maximiliano #portrait:Maximiliano #layout:right

No puedes estar ningún día sin molestar a alguien, o dar pena ajena. #speaker:Maxine #portrait:Maxine #layout:left

... #speaker:Maximiliano #portrait:Maximiliano #layout:right

Disculpalo es solo que a veces no se controla, ya para ¿Quieres?! #speaker:Maxine #portrait:Maxine #layout:left
Vuelves a hacer algo parecido y le comento a nuestros padres.  

Te veo en la clase de deportes, no des mas problemas.

... #speaker:Maximiliano #portrait:Maximiliano #layout:right
Vaya, lo siento, la verdad es que solo quiero llamar la atencion de Maxi.
Pero cada que lo intento se aleja mas de mi.
Pienso ganarme su cariño de hermana con esto.

(Maximiliano muestra un collar con forma de corazon al que le hace falta algo) #layout:basic

Se que le encantara, pero me faltan unos detalles y alguien que este dispuesto a ayudarme #speaker:Maximiliano #portrait:Maximiliano #layout:right
{pausa()}
Que dices? Prometo dejar de molestar tanto a Viernes
*[No tengo otra opcion]
    Muy bien
    ->Decision
*[Lo hare, por Viernes]
    Pero si Viernes es un tarado, pero de acuerdo
    ->Decision
*[Que pasa si no quiero]
    No creo que quieras saber, asi que...
    ->Decision
    
===Decision===

{pausa()}

Sabia que podia confiar en ti

Ahora solo encargate de conseguirme un iman, es todo lo que me falta.

Ah.. y gracias

Supongo que le preguntare a Tito si tiene alguno #layout:basic



-> END