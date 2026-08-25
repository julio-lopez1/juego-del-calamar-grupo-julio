namespace juego_del_calamar_grupo_de_julio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------- CONSTANTES ----------
            const string NOMBRE_JUEGO = "EL JUEGO DEL CALAMAR";
            const int TOTAL_CUPOS = 3;
            const int EDAD_MINIMA = 18;
            const double PREMIO_TOTAL = 45600000000;
            const string PRUEBA_1 = "Luz roja, luz verde";
            const string PRUEBA_2 = "Dalgona";
            const string PRUEBA_3 = "Tira y afloja";
            const string ESTADO_VIVO = "SOBREVIVE";
            const string ESTADO_FUERA = "ELIMINADO";

            // ---------- VARIABLES ----------
            string jugador1;
            string jugador2;
            string jugador3;

            string jugadorElegido = "";
            string estadoFinal = "";
            string pruebaElegida = "";
            string clasificacion = "";

            int numeroJugador = 0;
            int opcionJugador;
            int opcionPrueba = 0;
            int decision = 0;
            int edad = 0;
            int puntaje = 0;

            // ---------- PORTADA ----------
            Console.WriteLine("==================================================");
            Console.WriteLine("          " + NOMBRE_JUEGO);
            Console.WriteLine("          UNICEN - PROGRAMACION II");
            Console.WriteLine("==================================================");
            Console.WriteLine("Premio acumulado : " + PREMIO_TOTAL + " wones");
            Console.WriteLine("Cupos habilitados: " + TOTAL_CUPOS);
            Console.WriteLine("Edad minima      : " + EDAD_MINIMA + " anios");
            Console.WriteLine();

            // ---------- REGISTRO ----------
            Console.WriteLine("--- REGISTRO DE JUGADORES ---");

            Console.Write("Nombre del jugador 1: ");
            jugador1 = Console.ReadLine();

            Console.Write("Nombre del jugador 2: ");
            jugador2 = Console.ReadLine();

            Console.Write("Nombre del jugador 3: ");
            jugador3 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Jugadores inscritos:");
            Console.WriteLine("001 - " + jugador1);
            Console.WriteLine("002 - " + jugador2);
            Console.WriteLine("003 - " + jugador3);
            Console.WriteLine();

            // ---------- SELECCION DE JUGADOR ----------
            Console.WriteLine("--- SELECCION DE JUGADOR ---");
            Console.WriteLine("1) " + jugador1);
            Console.WriteLine("2) " + jugador2);
            Console.WriteLine("3) " + jugador3);

            Console.Write("Que jugador entra a la arena (1-3): ");
            opcionJugador = int.Parse(Console.ReadLine());

            if (opcionJugador == 1)
            {
                jugadorElegido = jugador1;
                numeroJugador = 1;
            }
            else if (opcionJugador == 2)
            {
                jugadorElegido = jugador2;
                numeroJugador = 2;
            }
            else if (opcionJugador == 3)
            {
                jugadorElegido = jugador3;
                numeroJugador = 3;
            }
            else
            {
                jugadorElegido = "SIN JUGADOR";
                numeroJugador = 0;
                estadoFinal = ESTADO_FUERA;
            }

            // ---------- CONTROL DE EDAD ----------
            if (numeroJugador != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Jugador seleccionado: 00" + numeroJugador +
                                  " - " + jugadorElegido);

                Console.Write("Ingrese la edad de " + jugadorElegido + ": ");
                edad = int.Parse(Console.ReadLine());

                if (edad < EDAD_MINIMA)
                {
                    Console.WriteLine("ACCESO DENEGADO. " +
                                      jugadorElegido + " es menor de edad.");
                    estadoFinal = ESTADO_FUERA;
                }
                else
                {
                    Console.WriteLine("ACCESO PERMITIDO. " +
                                      jugadorElegido + " puede competir.");
                    puntaje = puntaje + 20;

                    // ---------- SELECCION DE PRUEBA ----------
                    Console.WriteLine();
                    Console.WriteLine("--- SELECCION DE PRUEBA ---");
                    Console.WriteLine("1) " + PRUEBA_1);
                    Console.WriteLine("2) " + PRUEBA_2);
                    Console.WriteLine("3) " + PRUEBA_3);

                    Console.Write("Elija la prueba (1-3): ");
                    opcionPrueba = int.Parse(Console.ReadLine());

                    if (opcionPrueba == 1)
                    {
                        pruebaElegida = PRUEBA_1;

                        Console.WriteLine();
                        Console.WriteLine("PRUEBA: " + PRUEBA_1);
                        Console.WriteLine("¿Que hace cuando la muneca gira?");
                        Console.WriteLine("1) Seguir corriendo");
                        Console.WriteLine("2) Quedarse inmovil");
                        Console.WriteLine("3) Esconderse detras de otro");

                        Console.Write("Decision: ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            estadoFinal = ESTADO_FUERA;
                        }
                        else if (decision == 2)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 70;
                        }
                        else if (decision == 3)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 40;
                        }
                        else
                        {
                            estadoFinal = ESTADO_FUERA;
                        }
                    }
                    else if (opcionPrueba == 2)
                    {
                        pruebaElegida = PRUEBA_2;

                        Console.WriteLine();
                        Console.WriteLine("PRUEBA: " + PRUEBA_2);
                        Console.WriteLine("Elija la figura de la galleta:");
                        Console.WriteLine("1) Triangulo   (facil)");
                        Console.WriteLine("2) Estrella    (medio)");
                        Console.WriteLine("3) Sombrilla   (dificil)");

                        Console.Write("Figura elegida por " +
                                      jugadorElegido + ": ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            Console.WriteLine("El triangulo es una figura sencilla.");
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 50;
                        }
                        else if (decision == 2)
                        {
                            Console.WriteLine("La estrella requiere mucho cuidado.");

                            Console.Write("¿Lame la galleta? (1 = si / 2 = no): ");
                            decision = int.Parse(Console.ReadLine());

                            // ---------- IF ANIDADO ----------
                            if (decision == 1)
                            {
                                Console.WriteLine("La galleta se debilita.");
                                estadoFinal = ESTADO_VIVO;
                                puntaje = puntaje + 65;
                            }
                            else
                            {
                                Console.WriteLine("La galleta se rompe.");
                                estadoFinal = ESTADO_FUERA;
                            }
                        }
                        else if (decision == 3)
                        {
                            Console.WriteLine(
                                "La sombrilla es la figura mas dificil del juego.");

                            Console.Write(
                                "¿Usa la aguja calentada con el encendedor? " +
                                "(1 = si / 2 = no): ");

                            decision = int.Parse(Console.ReadLine());

                            // ---------- IF ANIDADO ----------
                            if (decision == 1)
                            {
                                Console.WriteLine(
                                    "La aguja caliente corta el azucar. " +
                                    jugadorElegido + " lo logra!");

                                estadoFinal = ESTADO_VIVO;
                                puntaje = puntaje + 80;
                            }
                            else
                            {
                                Console.WriteLine(
                                    "La galleta se rompe. " +
                                    jugadorElegido + " queda eliminado.");

                                estadoFinal = ESTADO_FUERA;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Figura inexistente.");
                            estadoFinal = ESTADO_FUERA;
                        }
                    }
                    else if (opcionPrueba == 3)
                    {
                        pruebaElegida = PRUEBA_3;

                        Console.WriteLine();
                        Console.WriteLine("PRUEBA: " + PRUEBA_3);
                        Console.WriteLine("¿Que estrategia utiliza?");
                        Console.WriteLine("1) Jalar con toda la fuerza");
                        Console.WriteLine("2) Inclinarse hacia atras");
                        Console.WriteLine("3) Soltar la cuerda");

                        Console.Write("Decision: ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            estadoFinal = ESTADO_FUERA;
                        }
                        else if (decision == 2)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 75;
                        }
                        else if (decision == 3)
                        {
                            estadoFinal = ESTADO_FUERA;
                        }
                        else
                        {
                            estadoFinal = ESTADO_FUERA;
                        }
                    }
                    else
                    {
                        pruebaElegida = "PRUEBA INVALIDA";
                        estadoFinal = ESTADO_FUERA;
                    }
                }
            }
            else
            {
                pruebaElegida = "NINGUNA";
            }

            // ---------- CLASIFICACION ----------
            if (puntaje >= 90)
            {
                clasificacion = "FINALISTA";
            }
            else if (puntaje >= 60)
            {
                clasificacion = "AVANZA A LA SIGUIENTE RONDA";
            }
            else if (puntaje >= 30)
            {
                clasificacion = "PASA CON OBSERVACIONES";
            }
            else
            {
                clasificacion = "FUERA DE COMPETENCIA";
            }

            // ---------- REPORTE FINAL ----------
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("        REPORTE FINAL - " + NOMBRE_JUEGO);
            Console.WriteLine("==================================================");

            Console.WriteLine("Jugador       : " + jugadorElegido);
            Console.WriteLine("Numero        : " +
                              (numeroJugador == 0 ? "INVALIDO" : "00" + numeroJugador));
            Console.WriteLine("Prueba        : " + pruebaElegida);
            Console.WriteLine("Estado        : " + estadoFinal);
            Console.WriteLine("Puntaje       : " + puntaje + " / 100");
            Console.WriteLine("Clasificacion : " + clasificacion);

            if (estadoFinal == ESTADO_VIVO)
            {
                Console.WriteLine("Premio en juego: " + PREMIO_TOTAL + " wones");
            }

            Console.WriteLine("==================================================");

            Console.ReadKey(); ;
        }
    }
}
