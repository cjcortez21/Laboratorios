// proyecto 01 - Carlos Cortez - 2026
Console.WriteLine("Proyecto 01 Car wash");
Console.WriteLine("Carlos Cortez ");
Console.WriteLine("------------------------------");

int opcion = 0;
bool ticketactivo = false;
bool extrarinesactivo = false;
int totalrecaudado = 0;
int costextrarines = 0;
int carrosatendidos = 0;
int carrosconextrarines = 0;
int costbase = 0;
int desc = 0;
int totcobrar = costbase+costextrarines-desc;
int classcar = 0;
int sizerines = 0;
string placa = "";
int numcliente = 0;
do
{
    Console.WriteLine("Menu de opciones");
    Console.WriteLine("1 crear ticket de entrada");
    Console.WriteLine("2 lavado de llantas y rines");
    Console.WriteLine("3 consultar monto a cobrar");
    Console.WriteLine("4 salida y promoción");
    Console.WriteLine("5 salida del programa");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
           if (ticketactivo == false)
            {
                // while para repetir desde este punto si no se ingresa la placa correctamente
                while (placa.Length != 6)
                {
                    Console.WriteLine("Ingrese el numero de placa del vehiculo de 6 digitos sin espacios");
                    placa = Console.ReadLine();

                    // validación de placa , debe tener 6 caracteres sin espacios
                }

                    if (placa.Length == 6)
                    {
                        Console.WriteLine("Ticket de entrada creado para el vehiculo con placa: " + placa);
                        ticketactivo = true;
                        carrosatendidos++;

                    

                    // ingreso de tipo de vehiculo 

                    while (classcar != 1 && classcar != 2)
                    {
                        Console.WriteLine("ingrese el tipo de vehiculo ");
                    Console.WriteLine("1=sedan, 2=pickup/SUV");
                    classcar = Convert.ToInt32(Console.ReadLine());
                    


                        if (classcar == 1)
                        {
                            costbase = 50;

                            Console.WriteLine("ingrese su nombre");
                            string username = Console.ReadLine();

                            Console.WriteLine("ticket creado " + username + "  costo del lavado de sedan " + costbase);
                            ticketactivo = true;
                            extrarinesactivo = false;
                            costextrarines = 0;
                            totcobrar = costbase + costextrarines - desc;
                        }
                        else if (classcar == 2)
                        {
                            costbase = 70;
                            Console.WriteLine("ingrese su nombre");
                            string username = Console.ReadLine();

                            Console.WriteLine("ticket creado " + username + "  costo del lavado de SUV " + costbase);
                            ticketactivo = true;
                            extrarinesactivo = false;
                            costextrarines = 0;
                            totcobrar = costbase + costextrarines - desc;
                        }
                        else
                        {
                            Console.WriteLine("tipo de vehiculo no valido repita el proceso");

                        }



                    }


                }

                    else // no ingreso placa correctamente , no se puede crear el ticket
                    {
                    Console.WriteLine("Numero de placa invalido, debe tener 6 digitos sin espacios");
                    }

            }
            else // si ya hay un ticket activo, no se puede crear otro
            {
                Console.WriteLine("Ya hay un ticket activo, no puede crear otro ");
            }






         


            break;
        case 2:
            // proceso de lavado de rines 
            if (ticketactivo == true) {
                // validacion de ticket rines 
                if (extrarinesactivo == true)
                {
                    Console.WriteLine("Ya se ha agregado el lavado de llantas y rines. desea cancelarlo?");
                    string cancelrines = Console.ReadLine();
                    // validacion de cancelacion de rines
                    if (cancelrines == "si" || cancelrines == "Si")
                    {
                        extrarinesactivo = false;
                        costextrarines = 0;
                        sizerines = 0;
                        carrosconextrarines--;
                        Console.WriteLine("Lavado de llantas y rines cancelado");
                    }
                    else if (cancelrines == "no" || cancelrines == "No")
                    {
                        Console.WriteLine("Lavado de llantas y rines mantenido");
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida, por favor ingrese si o no");
                    }


                }
                else
                {
                    // opciones de lavado de rines
                    while (sizerines < 12 || sizerines > 22)
                    { 

                    Console.WriteLine("ingrese el tamaño de su rin ");
                    sizerines = Convert.ToInt32(Console.ReadLine());

                    if (sizerines >= 12 && sizerines <= 16)
                    {
                        costextrarines = 30;
                        extrarinesactivo = true;
                        Console.WriteLine("Lavado de llantas y rines agregado, costo adicional " + costextrarines);
                        carrosconextrarines++;
                    }

                    else if (sizerines >= 17 && sizerines <= 19)
                    {
                        costextrarines = 40;
                        extrarinesactivo = true;
                        Console.WriteLine("Lavado de llantas y rines agregado, costo adicional " + costextrarines);
                        carrosconextrarines++;
                    }

                    else if (sizerines >= 20 && sizerines <= 22)
                    {
                        costextrarines = 60;
                        extrarinesactivo = true;
                        carrosconextrarines++;
                        Console.WriteLine("Lavado de llantas y rines agregado, costo adicional " + costextrarines);

                    }
                    else // si el tamaño de rin no es valido
                    {

                        Console.WriteLine("Tamaño de rin no valido, ingrese un numero valido");
                    }

                }

                    }

            }


            else { 
            Console.WriteLine("No hay un ticket activo, por favor cree un ticket de entrada primero");
            }

                break;

        case 3:
             if (ticketactivo == true)
            // proceso de consulta de monto a cobrar
            {
                totcobrar = costbase + costextrarines - desc;
                Console.WriteLine("El monto a cobrar es: " + totcobrar);
            }
          else {  
                Console.WriteLine("No hay un ticket activo, por favor cree un ticket de entrada primero");
            }
            break;


        case 4:

            if (ticketactivo == true) {

                // proceso de salida y promoción
                while (numcliente < 1 || numcliente > 3)
                {
                    Console.WriteLine("ingrese un numero del 1 al 3 para la promo ");
                    numcliente = Convert.ToInt32(Console.ReadLine());
                    if (numcliente < 1 || numcliente > 3)
                    {
                        Console.WriteLine("Numero no valido, intente de nuevo");
                    }
                }
              
                // lectura de numero para promocion 
                if (numcliente >= 1 && numcliente <= 3)
                    {
                    Random numrandom = new Random();
                    int numeroRandom = numrandom.Next(1, 4);

                    if (numcliente == numeroRandom)
                    {
                        desc = 20;
                        totcobrar = costbase + costextrarines - desc;
                        totalrecaudado += totcobrar;
                        Console.WriteLine("Felicidades, ha ganado un descuento de 20Q, su total a pagar es: " + totcobrar);

                    }
                    else
                    {
                        desc = 0;
                        totcobrar = costbase + costextrarines - desc;
                        totalrecaudado += totcobrar;
                        Console.WriteLine("Lo siento, no ha ganado un descuento, su total a pagar es: " + totcobrar);
                   
                    }
                    // reinicio de variables para el siguiente cliente
                    ticketactivo = false;
                    extrarinesactivo = false;
                    costextrarines = 0;
                    costbase = 0;
                    desc = 0;
                    classcar = 0;
                    sizerines = 0;
                    placa = "";

                }

                    else
                    {
                        Console.WriteLine("Numero no valido, intente de nuevo");
                }

               
            }


            break; 


        case 5:
            totalrecaudado += totcobrar;
            break; 

        default:
            // no se ingreso una opcion valida
            Console.WriteLine("Opcion no valida, por favor ingrese una opcion del 1 al 5");
            break;
    }


}
while (opcion != 5);

// resumen final del programa al salir
Console.WriteLine("Gracias por usar el programa, total recaudado: " + totalrecaudado);
Console.WriteLine(" Total de carros atendidos: " + carrosatendidos);
Console.WriteLine(" Total de carros con lavado de llantas y rines: " + carrosconextrarines);