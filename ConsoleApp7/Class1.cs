using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Studente
    { 
        public class Persona
            {  
                public string Name { get; set; }
                public string Cognome { get; set; }
                public DateTime DataDiNascita { get; set; }
            } 
        public class Insegnanti 
            {  
            public float Voto { get; set;}
            public string Materia { get; set;}
            public DateTime Data { get; set; }
            }
    }
    internal class Insegnante
    {
        public class Persona
        {
            public string Name { get; set; }
            public string Cognome { get; set; }
            public DateTime DataDiNascita { get; set; }
        }
        public class Materia
        {
            public float Sigla { get; set; }
            public string Nome { get; set; }
        }
    }

}

