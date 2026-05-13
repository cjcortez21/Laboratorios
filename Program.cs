using System.Diagnostics.Metrics;
using static System.Net.WebRequestMethods;

namespace proyecto02_welcometolatam_Carlos_Cortez
{
    internal class Program
    {
    public static double dineroincial =  0;
    public static double dineroactual = 0;
    public static int numempleados = 0;   
    public static double sueldoempleado= 0;
    public static int messimular = 0;
    public static int mesrestantes = 0;
    public static int mesessimulados = 0;
    public static int filas = 0;
    public static int columnas = 0;
    public static int opmenu = 0;
    public static int opsembradio = 0;
    public static int respuesta = 0;
    public static double dinerofinal = 0;
    public static double totingreso = 0;
    public static double totegreso = 0;
    public static int mesessimuladoss = 0;
    public static int sembradasmaiz = 0;
    public static int sembradaslechuga = 0;
    public static int sembradaszanahoria = 0;
    public static int cultivadaszanahoria = 0;
    public static int cultivadasmaizs = 0;
    public static int cultivadaslechugas = 0;
        static void Main(string[] args)
        {


            Console.WriteLine("hola bienvenido a latam simulator, \r\ningrese sus datos inciales \r\npara comenzar la partida");

            Console.WriteLine("ingrese el dinero inicial");
            dineroincial = Convert.ToDouble(Console.ReadLine());
            dineroactual = dineroincial;

            Console.WriteLine("ingrese el numero de empleados que tiene su empresa");
            numempleados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el sueldo de cada empleado");
            sueldoempleado = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese el numero de meses que desea simular");
            messimular = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("perfecto ahora deme las dimensioones de su terreno para sembrar"); 

            Console.WriteLine("ingrese el numero de filas");
            filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el numero de columnas");
            columnas = Convert.ToInt32(Console.ReadLine());


            sembradio [,] cosechas = new sembradio[filas, columnas];

            for(int i = 0; i < filas; i++)
            {
                for(int k = 0; k < columnas; k++)
                {
                    cosechas[i, k] = new sembradio("V", 0, 0, 0, 0, false, true);
                }
            }

            do
            {
                Console.WriteLine("Bienvenido, que accion desea hacer\r\n1. sembrar \r\n 2. Fertilizar  \r\n3. Consultar parcela \r\n4. avanzar mes \r\n5. salir");
                opmenu = Convert.ToInt32(Console.ReadLine());
                switch (opmenu)
                {
                    case 1:

                        // aqui se hace el ciclo si el usurario pone un parcela que no existe y le vuelve a preguntar
                        bool messi = false;
                        do
                        {
                            Console.WriteLine("Ingrese fila y columnas de parcela en la cual ingresara el cultivo: ");
                            filas = Convert.ToInt32(Console.ReadLine());

                            columnas = Convert.ToInt32(Console.ReadLine());

                            if (filas < 0 || filas >= cosechas.GetLength(0) || columnas < 0 || columnas >= cosechas.GetLength(1))
                            {
                                Console.WriteLine("parcela no valida, ingrese de nuevo");

                            }
                            else
                            {
                                if (cosechas[filas, columnas].vacia == false)
                                {
                                    Console.WriteLine("La parcela ya tiene una siembra, ingrese de nuevo otra ");
                                }
                                else
                                {
                                    messi = true;
                                }
                            }
                        } while (messi == false);
                        // termina el ciclo de validacion de parcela

                        do
                        {
                            // el usuario elige le tipo de cultivo que desea sembrar y se asignan las caracteristicas a la parcela
                            Console.WriteLine("Ingrese el tipo de cultivo que desea sembrar: \r\n1. Maiz \r\n2. Lechuga \r\n3. Zanahoria");
                            opsembradio = Convert.ToInt32(Console.ReadLine());

                            if (opsembradio == 1)
                            {
                                cosechas[filas, columnas].tipodecultivo = "M";
                                cosechas[filas, columnas].mesescrecer = 3;
                                cosechas[filas, columnas].preciocosecha = 700;
                                cosechas[filas, columnas].vacia = false;
                                cosechas[filas, columnas].mesesrestantes = 3;
                                sembradasmaiz += 1;
                                Console.WriteLine("sembrado exitoso");
                            }
                            else if (opsembradio == 2)
                            {
                                cosechas[filas, columnas].tipodecultivo = "L";
                                cosechas[filas, columnas].mesescrecer = 1;
                                cosechas[filas, columnas].preciocosecha = 200;
                                cosechas[filas, columnas].vacia = false;
                                cosechas[filas, columnas].mesesrestantes = 1;
                                sembradaslechuga += 1;
                                Console.WriteLine("sembrado exitoso");
                            }
                            else if (opsembradio == 3)
                            {
                                cosechas[filas, columnas].tipodecultivo = "Z";
                                cosechas[filas, columnas].mesescrecer = 2;
                                cosechas[filas, columnas].preciocosecha = 500;
                                cosechas[filas, columnas].vacia = false;
                                cosechas[filas, columnas].mesesrestantes = 2;
                                sembradaszanahoria += 1;
                                Console.WriteLine("sembrado exitoso");
                            }
                            else
                            {
                                Console.WriteLine("ingrese una opcion valida ");
                            }


                            
                        } while (opsembradio != 1 &&  opsembradio != 2 &&  opsembradio != 3 );
                        break;
                    // parte de fertilizar
                    case 2:
                        {
                            // se le pregutna parcela a ferttilizar y se valida que exista y no tenga fertilizante
                            // cristiano es de uso para validar que sea correcta la parcela a fertilizar, si no es correcta vuelve a preguntar
                            Console.WriteLine("que parcela desea fertilizar");
                            bool cristiano = false;
                            do
                            {
                                Console.WriteLine("Ingrese fila y columnas de parcela en la cual ingresara el cultivo: ");
                                filas = Convert.ToInt32(Console.ReadLine());

                                columnas = Convert.ToInt32(Console.ReadLine());

                                if (cosechas[filas, columnas].vacia == true)
                                {
                                    Console.WriteLine("parcela no tiene siembra no se puede fertilizar");

                                }
                                else
                                {
                                    if (cosechas[filas, columnas].fertilizante == true)
                                    {
                                        Console.WriteLine("La parcela ya tiene fertilizante, ingrese de nuevo otra ");
                                    }
                                    else
                                    {
                                        cristiano = true;
                                    }
                                }

                            } while (cristiano == false);

                            // se verifica que tenga fondos para poder fertilizar 
                            if (dineroactual < 50)
                            {
                                Console.WriteLine("no tienes suficiente dinero para fertilizar esta parcela");
                                break;
                            }
                            // si tiene fondos agrega el fertilizante
                            cosechas[filas, columnas].fertilizante = true;
                            cosechas[filas, columnas].preciocosecha = cosechas[filas, columnas].preciocosecha * 1.1;
                            Console.WriteLine("agregado fertilizate a la casilla que corresponde ");
                            dineroactual = dineroactual - 50;
                            totegreso += 50;
                            // a las parcelas de al lado si cumplen con las condiciones se les agrega tambien a ellos 

                           
                                if ((filas - 1 >= 0))
                                {
                                    if ((cosechas[filas - 1, columnas].vacia == false))
                                    {
                                        if ((cosechas[filas - 1, columnas].fertilizante == false))
                                        {
                                            cosechas[filas - 1, columnas].fertilizante = true;
                                            cosechas[filas - 1, columnas].preciocosecha = cosechas[filas - 1, columnas].preciocosecha * 1.1;
                                            Console.WriteLine("agregado fertilizate a la parcela de la izquierda ");
                                        }
                                    }

                                }
                                if ((filas + 1 < cosechas.GetLength(0)))
                                {
                                    if ((cosechas[filas + 1, columnas].vacia == false))
                                    {
                                        if ((cosechas[filas + 1, columnas].fertilizante == false))
                                        {
                                            cosechas[filas + 1, columnas].fertilizante = true;
                                            cosechas[filas + 1, columnas].preciocosecha = cosechas[filas + 1, columnas].preciocosecha * 1.1;
                                            Console.WriteLine("agregado fertilizate a la parcela de la izquierda ");
                                        }
                                    }
                                }
                            
                            else { }
                            
                        }
                        // inicio de caso 3 y finalización del 2
                            break;
                    case 3:
                        // el usuario ingresa la casilla que debe consultar 
                        Console.WriteLine("que parcela desea consultar");

                        Console.WriteLine("Ingrese fila y columnas de la parcela a consultar ");
                        do
                        {
                            filas = Convert.ToInt32(Console.ReadLine());

                            columnas = Convert.ToInt32(Console.ReadLine());

                            if (filas < 0 || filas >= cosechas.GetLength(0) || columnas < 0 || columnas >= cosechas.GetLength(1))
                            {
                                Console.WriteLine("parcela no valida, ingrese de nuevo");
                            }
                            else
                            { }
                        } while (filas < 0 || filas >= cosechas.GetLength(0) || columnas < 0 || columnas >= cosechas.GetLength(1));
                       // se le brindan los datos
                        Console.WriteLine("tipo de siembra " + cosechas[filas, columnas].tipodecultivo);
                        Console.WriteLine("edad de la siembra " + cosechas[filas, columnas].edad);
                        Console.WriteLine("meses que debe pasar para crecer " + cosechas[filas, columnas].mesescrecer);
                        Console.WriteLine("meses restantes para crecer " + cosechas[filas, columnas].mesesrestantes);
                        Console.WriteLine("precio de la cosecha " + cosechas[filas, columnas].preciocosecha);
                        Console.WriteLine("tiene fertilizante? " + cosechas[filas, columnas].fertilizante);
                        // se agrega una consulta resue
                        Console.WriteLine("desea ver un resumen de todas las parcelas? \r\n1. si \r\n2. no");
                        respuesta = Convert.ToInt32(Console.ReadLine());
                        if (respuesta == 1)
                        {
                            for (int i = 0; i < cosechas.GetLength(0); i++)
                            {
                                for (int k = 0; k < cosechas.GetLength(1); k++)
                                {
                                    Console.Write(" |" + cosechas[i, k].tipodecultivo + " |");
                                }
                                Console.WriteLine("");
                            }
                        }
                        else { }


                        break;
                    case 4:

                        // aqui se realiza el avanzado de mes y recolecta de las cosechas
                        Console.WriteLine("avanzando mes");
                        if (dineroactual < 0)
                        {
                            Console.WriteLine("no tienes dinero para pagar a tus empleados, por lo finalizamos el juego");
                            opmenu = 5;
                            break;
                        }
                        mesrestantes += 1;

                        for (int i = 0; i < cosechas.GetLength(0); i++)
                        {
                            for (int j = 0; j < cosechas.GetLength(1); j++)
                            {
                                if (cosechas[i, j].vacia == false)
                                {
                                    cosechas[i, j].edad += 1;
                                    cosechas[i, j].mesesrestantes -= 1;
                                    if (cosechas[i, j].mesesrestantes == 0)
                                    {
                                        dineroactual += cosechas[i, j].preciocosecha;
                                        totingreso += cosechas[i, j].preciocosecha;
                                        // esto es para el registro de que se cultivo
                                        if (cosechas[i, j].tipodecultivo == "M")
                                        {
                                            cultivadasmaizs += 1;
                                        }
                                        else if (cosechas[i, j].tipodecultivo == "L")
                                        {
                                            cultivadaslechugas++;
                                        }
                                        else if (cosechas[i, j].tipodecultivo == "Z")
                                        {
                                            cultivadaszanahoria += 1;
                                        }
                                        // los datos que se expresan y se reincia la parcela 
                                        Console.WriteLine("se ha cosechado una parcela en la fila " + i + " y columna " + j);
                                        Console.WriteLine("dinero ganado" + cosechas[i, j].preciocosecha);
                                        cosechas[i, j] = new sembradio("V", 0, 0, 0, 0, false, true);
                                        dineroactual = dineroactual - (sueldoempleado * numempleados);
                                        totegreso += (sueldoempleado * numempleados);


                                    }
                                }
                                else { }

                            }

                        }
                        // opciones si cumple condiciones 
                        if (dineroactual < 0)
                        {
                            Console.WriteLine("no tienes dinero para pagar a tus empleados, por lo finalizamos el juego");
                            opmenu = 5;
                        }
                        if (mesrestantes == messimular)
                        {
                            Console.WriteLine("se han cumplido los meses a simular, por lo tanto finalizamos el juego");
                            opmenu = 5;
                        }
                            break;
                    case 5:
                        Console.WriteLine("gracias por jugar");
                        break;
                    default:
                        Console.WriteLine("opcion no valida");
                        break;
                }
            }
            // termina el codigo y da los datos de finalización del juego
            while (opmenu != 5);
            dinerofinal = dineroactual;
                Console.WriteLine("dinero inicial: " + dineroincial);
                Console.WriteLine("dinero final: " + dinerofinal);
                Console.WriteLine("total ingresos: " + totingreso);
                Console.WriteLine("total egresos: " + totegreso);
                Console.WriteLine("parcela sembradas de maiz: " + sembradasmaiz);
                Console.WriteLine("parcela sembradas de lechuga: " + sembradaslechuga);
                Console.WriteLine("parcela sembradas de zanahoria: " + sembradaszanahoria);
                Console.WriteLine("parcela cultivadas de maiz: " + cultivadasmaizs);
                Console.WriteLine("parcela cultivadas de lechuga: " + cultivadaslechugas);
                Console.WriteLine("parcela cultivadas de zanahoria: " + cultivadaszanahoria);


        }
    }
}
