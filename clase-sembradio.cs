using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto02_welcometolatam_Carlos_Cortez
{
    internal class clase_sembradio
    { }
        class sembradio
        {
            public string  tipodecultivo ;
            public int edad ;
            public int mesescrecer ;
            public int mesesrestantes ;
            public double preciocosecha ;
            public bool fertilizante ;
            public bool vacia ;
            public  sembradio (string tipodecultivo, int edad, int mesescrecer, int mesesrestantes, double preciocosecha, bool fertilizante, bool vacia)
            {
                this.tipodecultivo = tipodecultivo;
                this.edad = edad;
                this.mesescrecer = mesescrecer;
                this.mesesrestantes = mesesrestantes;
                this.preciocosecha = preciocosecha;
                this.fertilizante = fertilizante;
                this.vacia = vacia;
            }

      
        }
    }
//

