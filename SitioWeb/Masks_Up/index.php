<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Masks Up</title>

    <script src="https://cdn.tailwindcss.com"></script>
    <style type="text/tailwindcss">
        @layer utilities {
            html{
                scroll-behavior: smooth;
            }
        }

        .active {
            @apply bg-[#4B0000];
            @apply text-[#EDB700]
        }
    </style>

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

    <link
        rel="stylesheet"
        href="https://cdn.jsdelivr.net/npm/swiper@10/swiper-bundle.min.css"
    />
    <script src="https://cdn.jsdelivr.net/npm/swiper@10/swiper-bundle.min.js"></script>

    <script src="jquery/jquery-3.7.1.min.js"></script>
</head>
<body>
    <div class="w-full">
        <nav class="w-full fixed z-[100]">
            <ul class="flex justify-center gap-8 items-center px-8 py-4">
                <li class="text-white font-bold text-xl hover:bg-[#4B0000] rounded-xl px-4 py-2 active transition-all duration-500"><a href="#inicio" class="transition-all duration-300">Inicio</a></li>
                <li class="text-white font-bold text-xl hover:bg-[#4B0000] rounded-xl px-4 py-2 transition-all duration-500"><a href="#sobre_nosotros" class="transition-all duration-300">Sobre Nosotros</a></li>
                <li class="text-white font-bold text-xl hover:bg-[#4B0000] rounded-xl px-4 py-2 transition-all duration-500"><a href="#objetivos" class="transition-all duration-300">Objetivos</a></li>
                <li class="text-white font-bold text-xl hover:bg-[#4B0000] rounded-xl px-4 py-2 transition-all duration-500"><a href="#personajes" class="transition-all duration-300">Personajes</a></li>
                <li class="text-white font-bold text-xl hover:bg-[#4B0000] rounded-xl px-4 py-2 transition-all duration-500"><a href="#estadisticas" class="transition-all duration-300">Estadísticas</a></li>
                <li class="text-white font-bold text-xl hover:bg-[#4B0000] rounded-xl px-4 py-2 transition-all duration-500"><a href="#contacto" class="transition-all duration-300">Contacto</a></li>
            </ul>
        </nav>

        <div id="inicio" class="w-full h-screen bg-[#610000]">
            <div class="w-full h-full max-w-[1140px] flex justify-center items-center mx-auto">
                <div className='w-full flex flex-col'>
                    <h1 class="text-6xl font-extrabold text-[#EDB700]">
                        Masks Up - Las apariencias engañan!
                    </h1>

                    <p class="text-[28px] text-black-100 font-light mt-5 text-white">
                        En este juego, tomarás decisiones que te llevarán a saber si padeces de algun trastorno mental.
                    </p>

                    <button class="mt-8 px-3 py-2 border-[3px] flex items-center gap-4 max-w-[150px] hover:bg-white hover:text-black cursor-pointer text-white duration-200 transition-all ease-in-out">
                        <span class="text-lg font-semibold">
                            Descargar
                        </span>
                        <img src="images/arrow-right.png" alt="flecha derecha" class="w-6" />
                    </button>
                </div>

                <div>
                    <img src="images/principal.png" alt="hombre" class="w-[30rem] object-contain" />
                </div>
            </div>
        </div>

        <div id="sobre_nosotros" class="w-full h-screen bg-[#EDB700]">
            <div class="w-full h-full max-w-[1140px] flex justify-center items-center mx-auto">
                <div>
                    <img src="images/familia3.png" alt="hombre" class="w-[100rem] object-contain" />
                </div>

                <div class="px-8">
                    <h2 class="font-extrabold text-5xl">
                        Sobre Nosotros
                    </h2>

                    <p class="text-lg mt-8 text-justify">
                    En Masks Up, estamos dedicados a la creación de experiencias interactivas que van más allá del entretenimiento; 
                    estamos comprometidos en hacer una diferencia significativa en la vida de las personas. Nuestro enfoque se centra en 
                    la detección y el apoyo de trastornos mentales, proporcionando una plataforma única que combina la diversión de los 
                    videojuegos con un compromiso serio para el bienestar mental.
                    </p>
                    <p class="text-lg mt-8 text-justify">
                    Uno de los aspectos clave de nuestro proyecto es la creación de un apartado de estadísticas que permita a los 
                    profesionales de la salud, en particular a los psicólogos, obtener información valiosa sobre el estado de sus 
                    pacientes y clientes. Esto no solo agiliza el proceso de diagnóstico y seguimiento, sino que también abre nuevas 
                    posibilidades para el tratamiento y la atención personalizada.
                    </p>
                </div>
            </div>
        </div>

        <div id="objetivos" class="w-full h-screen bg-[#610000]">
            <div class="w-full h-full max-w-[1140px] flex justify-center items-center mx-auto">
                <div class='w-full flex flex-col'>
                    <div class="flex justify-center items-center">
                        <img src="images/mascota.png" alt="Mascota" class="object-contain w-[8rem]">
                        <h2 class="text-5xl font-extrabold text-white">
                            Objetivos
                        </h2>
                        <img src="images/mascota.png" alt="Mascota" class="object-contain w-[8rem]">
                    </div>

                    <div class="flex gap-8 justify-between mt-8">
                        <div class='rounded-lg bg-[#480000] shadow-lg w-1/2 p-4'>
                            <div class="flex items-center justify-center">
                                <h3 class='font-bold text-2xl text-white'>Objetivo general</h3>
                                <img src="images/reloj1.png" alt="mascota" class="object-contain w-[6rem]" />
                            </div>
                            
                            <p class='mt-2 text-white text-justify'>
                                Desarrollar un videojuego que atrape al usuario dentro de una historia melodramática donde el final depende de las
                                decisiones que este haya tomado. Determinando si sus acciones son indicios de un trastorno mental, para después apoyarlo
                                con ayuda psicológica, disminuyendo así la gravedad de su diagnóstico.
                            </p>
                        </div>

                        <div class='rounded-lg bg-[#480000] shadow-lg w-1/2 p-4'>
                            <div class="flex items-center justify-center">
                                <h3 class='font-bold text-2xl text-white'>Objetivos específicos</h3>
                                <img src="images/PasaTiempo1.png" alt="mascota" class="object-contain w-[6rem]" />
                            </div>

                            <ul class='mt-2 pl-4 list-disc text-white'>
                                <li>Mejorar el autoestima del usuario.</li>
                                <li>Mejorar la capacidad de la toma de decisiones ante sucesos detonantes.</li>
                                <li>Informe continuo y apoyo sobre las debilidades del usuario.</li>
                                <li>Recopilar información acerca de los usuarios para llevar acabo un análisis.</li>
                                <li>Analizar los patrones de decisión del usuario.</li>
                                <li>Innovar sobre las tecnologías de análisis psicológicos.</li>
                                <li>Entretener al usuario.</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div id="personajes" class="w-full h-screen bg-[#EDB700]">
            <div class="w-full h-full max-w-[1140px] flex justify-center items-center mx-auto">
                <div className='w-full flex flex-col'>
                    <h2 class="text-5xl font-extrabold text-center">
                        Personajes
                    </h2>

                    <div class="swiper w-[1140px] max-w-[1140px] h-[100%] mt-12">
                        <div class="swiper-wrapper">
                            <div class="swiper-slide">
                                <div class="w-full flex gap-x-4 h-full justify-center items-center">
                                    <h3 class="font-bold text-2xl text-[#610000]">Personaje Principal</h3>
                                    <img src="images/principal.png" alt="Personaje Principal" class="object-contain w-[15rem]">
                                </div>
                            </div>

                            <div class="swiper-slide">
                                <div class="w-full flex gap-x-4 h-full justify-center items-center">
                                    <h3 class="font-bold text-2xl text-[#610000]">Mascota</h3>
                                    <img src="images/mascota.png" alt="Mascota" class="object-contain w-[20rem]">
                                </div>
                            </div>
                            
                            <div class="swiper-slide">
                                <div class="w-full flex gap-x-4 h-full justify-center items-center">
                                    <h3 class="font-bold text-2xl text-[#610000]">Familiar 1</h3>
                                    <img src="images/familia1.png" alt="Familiar 1" class="object-contain w-[15rem]">
                                </div>
                            </div>

                            <div class="swiper-slide">
                                <div class="w-full flex gap-x-4 h-full justify-center items-center">
                                    <h3 class="font-bold text-2xl text-[#610000]">Familiar 2</h3>
                                    <img src="images/familia2.png" alt="Familiar 2" class="object-contain w-[15rem]">
                                </div>
                            </div>

                            <div class="swiper-slide">
                                <div class="w-full flex gap-x-4 h-full justify-center items-center">
                                    <h3 class="font-bold text-2xl text-[#610000]">Familiar 3</h3>
                                    <img src="images/familia3.png" alt="Familiar 3" class="object-contain w-[15rem]">
                                </div>
                            </div>

                            <div class="swiper-slide">
                                <div class="w-full flex gap-x-4 h-full justify-center items-center">
                                    <h3 class="font-bold text-2xl text-[#610000]">Personaje secundario 1</h3>
                                    <img src="images/secundario1.png" alt="Personaje secundario 1" class="object-contain w-[15rem]">
                                </div>
                            </div>

                            <div class="swiper-slide">
                                <div class="w-full flex gap-x-4 h-full justify-center items-center">
                                    <h3 class="font-bold text-2xl text-[#610000]">Personaje secundario 2</h3>
                                    <img src="images/secundario2.png" alt="Personaje secundario 2" class="object-contain w-[15rem]">
                                </div>
                            </div>

                            <div class="swiper-slide">
                                <div class="w-full flex gap-x-4 h-full justify-center items-center">
                                    <h3 class="font-bold text-2xl text-[#610000]">Personaje secundario 3</h3>
                                    <img src="images/secundario3.png" alt="Personaje secundario 3" class="object-contain w-[15rem]">
                                </div>
                            </div>
                        </div>

                        <div class="swiper-pagination"></div>
                        <div class="swiper-button-prev"></div>
                        <div class="swiper-button-next"></div>

                        <div class="swiper-scrollbar"></div>
                    </div>
                </div>
            </div>
        </div>

        <div id="estadisticas" class="w-full h-screen bg-[#610000]">
            <div class="w-full h-full max-w-[1140px] flex justify-center items-center mx-auto">
                <div className='w-full flex flex-col'>
                    <h2 class="text-5xl font-extrabold text-white text-center">
                        Estadísticas
                    </h2>

                    <table class="bg-white mt-8 statsTable rounded-md divide-y-2">
                        <tr class="py-14 bg-[#EDB700]">
                            <th class="px-4 py-2 text-center">Nombre de usuario</th>
                            <th class="px-4 py-2 text-center">Edad</th>
                            <th class="px-4 py-2 text-center">Diagnóstico</th>
                            <th class="px-4 py-2 text-center">Tiempo jugado</th>
                        </tr>
                        <tr>
                            <td class="px-4 py-2 text-center">Alejandro_Val</td>
                            <td class="px-4 py-2 text-center">23</td>
                            <td class="px-4 py-2 text-center">Inquieto</td>
                            <td class="px-4 py-2 text-center">01:32:15 hrs.</td>
                        </tr>
                        <tr>
                            <td class="px-4 py-2 text-center">Cesar_10</td>
                            <td class="px-4 py-2 text-center">23</td>
                            <td class="px-4 py-2 text-center">Abatido</td>
                            <td class="px-4 py-2 text-center">04:02:45 hrs.</td>
                        </tr>
                        <tr>
                            <td class="px-4 py-2 text-center">Leonardo_7</td>
                            <td class="px-4 py-2 text-center">22</td>
                            <td class="px-4 py-2 text-center">Impulsivo</td>
                            <td class="px-4 py-2 text-center">03:00:08 hrs.</td>
                        </tr>
                        <tr>
                            <td class="px-4 py-2 text-center">Victorino_R</td>
                            <td class="px-4 py-2 text-center">21</td>
                            <td class="px-4 py-2 text-center">Repetitivo</td>
                            <td class="px-4 py-2 text-center">07:55:01 hrs.</td>
                        </tr>
                        <tr>
                            <td class="px-4 py-2 text-center">Pedro</td>
                            <td class="px-4 py-2 text-center">24</td>
                            <td class="px-4 py-2 text-center">Cambiante</td>
                            <td class="px-4 py-2 text-center">02:02:36 hrs.</td>
                        </tr>
                        <tr>
                            <td class="px-4 py-2 text-center">Iduna_Mtz</td>
                            <td class="px-4 py-2 text-center">23</td>
                            <td class="px-4 py-2 text-center">Insegura</td>
                            <td class="px-4 py-2 text-center">03:42:36 hrs.</td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>

        <div id="contacto" class="w-full h-screen bg-[#EDB700]">
            <div class="w-full h-full max-w-[1140px] flex justify-center items-center mx-auto">
                <div className='w-full flex flex-col'>
                    <h2 class="text-6xl font-extrabold text-center">
                        Contacto
                    </h2>

                    <div class="flex justify-center items-center gap-x-8 w-full">
                        <form class='flex flex-col gap-y-8 w-full mt-12'>
                            <input type="text" placeholder='Nombre' required class='px-4 py-4 rounded-2xl w-full' />
                            <input type="text" placeholder='Apellido' required class='px-4 py-4 rounded-2xl w-full' />
                            <input type="mail" placeholder='Correo' required class='px-4 py-4 rounded-2xl w-full' />
                            <textarea name="mensaje" cols="30" rows="10" required maxLength={200} placeholder='Mensaje...' class='px-4 py-4 rounded-2xl'></textarea>
                            <button
                                type='submit'
                                class='rounded-2xl py-4 bg-[#b39430] text-white font-bold tracking-wider w-1/2 mx-auto
                                hover:bg-[#84702d] transition-all duration-300 ease-linear'
                            >
                                Enviar
                            </button>
                        </form>

                        <div>
                            <img src="images/extra1.png" alt="Personaje Extra 1" class="w-[40rem]" />
                        </div>
                    </div> 
                </div>
            </div>
        </div>

    </div>
</body>
</html>

<script>
    const swiper = new Swiper('.swiper', {
        direction: 'horizontal',
        spaceBetween: 500,
        effect: 'flip',
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
        },
        scrollbar: {
            el: '.swiper-scrollbar',
        },
    });

    document.addEventListener('DOMContentLoaded', function() {
    const navLinks = document.querySelectorAll('nav li');

    navLinks.forEach(link => {
        link.addEventListener('click', function(event) {
                navLinks.forEach(link => link.classList.remove('active'));

                link.classList.add('active');
            });
        });
    });

    // function segundosAFormatoTiempo(segundos) {
    //     var horas = Math.floor(segundos / 3600);
    //     var minutos = Math.floor((segundos % 3600) / 60);
    //     var segundosRestantes = segundos % 60;

    //     var formatoHoras = horas < 10 ? "0" + horas : horas;
    //     var formatoMinutos = minutos < 10 ? "0" + minutos : minutos;
    //     var formatoSegundos = segundosRestantes < 10 ? "0" + segundosRestantes : segundosRestantes;

    //     return formatoHoras + ":" + formatoMinutos + ":" + formatoSegundos;
    // }

    // (function () {
    //     $.ajax({
    //         url: './api/getUsers.php',
    //         type: 'POST',
    //         dataType: 'json',
    //         success: function(res) {
    //             if (res.encontrado) {
    //                 console.log(res);
    //                 for(let i = 0; i < res.data.length; i++){
    //                     let newRow = document.createElement('tr');
    //                     newRow.id = res.data[i].id;
    //                     document.querySelector('.statsTable').appendChild(newRow);

    //                     let newUsername = document.createElement('td');
    //                     newUsername.className = 'py-1 px-2 text-center';
    //                     newUsername.textContent = res.data[i].username;
    //                     document.getElementById(res.data[i].id).appendChild(newUsername);
                        
    //                     let newAge = document.createElement('td');
    //                     newAge.className = 'py-1 px-2 text-center';
    //                     newAge.textContent = res.data[i].age + " años";
    //                     document.getElementById(res.data[i].id).appendChild(newAge);

    //                     let newDiagnosis = document.createElement('td');
    //                     newDiagnosis.className = 'py-1 px-2 text-center';
    //                     newDiagnosis.textContent = res.data[i].diagnosis;
    //                     document.getElementById(res.data[i].id).appendChild(newDiagnosis);

    //                     let newPlayedTime = document.createElement('td');
    //                     newPlayedTime.className = 'py-1 px-2 text-center';
    //                     newPlayedTime.textContent = segundosAFormatoTiempo(Math.floor(res.data[i].playedTime)) + " hrs";
    //                     document.getElementById(res.data[i].id).appendChild(newPlayedTime);
    //                 }
    //             } else {
    //                 alert("No encontrado");
    //             }
    //         },
    //         error: function() {
    //             console.log("Error");
    //         }
    //     });
    // })();
</script>
