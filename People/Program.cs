using System;
using System.Collections.Generic;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<string, string>> nombres = new List<Tuple<string, string>>();
            nombres.Add(new Tuple<string, string>("Juan", "Pedro"));
            nombres.Add(new Tuple<string, string>("Juan", "Fernando"));
            nombres.Add(new Tuple<string, string>("Fernando", "Maria"));
            nombres.Add(new Tuple<string, string>("Maria", "Clara"));
            nombres.Add(new Tuple<string, string>("Juan", "Jose"));
            nombres.Add(new Tuple<string, string>("Carlos", "Fernando"));
            nombres.Add(new Tuple<string, string>("Manuel", "Carlos"));
            nombres.Add(new Tuple<string, string>("Jose", "Fernando"));



            var ejercicio = Saludar("Clara", "Juan");
            foreach (var item in ejercicio)
            {
                Console.WriteLine(item);
            }

            List<string> Saludar(string Saludado, string personaQueSaluda)
            {
                List<string> people = new List<string>();
             
                if (Saludado.Equals(personaQueSaluda))
                {
                    people.Add(personaQueSaluda);
                    return people;
                }        
                foreach (var tuple in nombres)
                {
                  
                    if (Saludado.Equals(tuple.Item2))
                    {
                        if (!people.Contains(Saludado))
                        {
                            people.Add(Saludado);
                        }                  
                        people.AddRange(Saludar( tuple.Item1, personaQueSaluda));
                    }
                }
                return people;
            }
        }
    }
}
