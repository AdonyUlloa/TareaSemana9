using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_semana_9
{
    class Perro
    {
        private int _perroId;
        private string _name;
        private string _raza;
        private int _age;
        private string _vacuna;


        public string _ownerName { get; set; }
        public int _telephoneNumber { get; set; }

        public void setperroId(int perroId)
        {
            _perroId = perroId;
        }

        public int getperroId()
        {
            return _perroId;
        }

        public void setName(string name)
        {
            _name = name;
        }
        public string getName()
        {
            return _name;
        }

        public void setRaza(string raza)
        {
            _raza = raza;
        }
        public string getRaza()
        {
            return _raza;
        }

        public void setAge(int age)
        {
            _age = age;
        }
        public int getAge()
        {
            return _age;
        }

        public void setVacuna (string vacuna)
        {
            _vacuna = vacuna;
        }
        public string getVacuna()
        {
            return _vacuna;
        }



        //public void setOwnerName(string ownerName)
        //{
        //    _ownerName = ownerName;
        //}
        //public string getOwnerName()
        //{
        //    return _ownerName;
        //}

        //public void setTelephoneNumber(int telephoneNumber)
        //{
        //    _telephoneNumber = telephoneNumber;
        //}

        //public int getTelephoneNumber()
        //{
        //    return _telephoneNumber;
        //}





        //public static List<Perro> GetPerros()
        //{
        //    List<Perro> perros = new List<Perro>
        //    {
        //        new Perro { perroId=0001, name="Luna", raza ="Labrador",age= 2 ,vacuna="Si", ownerName="Amanda Martinez",
        //            telephoneNumber= 2669-4514},
        //        new Perro { perroId=0002, name="Maya", raza="Lebrel",age= 2 , vacuna="Si", ownerName="Gloria Hernandez",
        //            telephoneNumber= 2564-2484},
        //        new Perro { perroId=0003, name="Bruno", raza="Lakeland terrier",age= 2 , vacuna="No", ownerName="Luis Quintanilla",
        //            telephoneNumber= 2848-5475},
        //        new Perro { perroId=0004, name="Max", raza="Lebrel escocés",age= 2 , vacuna="Si", ownerName="Armando Guardado",
        //            telephoneNumber= 2624-2567},
        //        new Perro { perroId=0005, name="Rocky", raza="Mastín inglés",age= 2 , vacuna="Si", ownerName="Alfredo Zelaya",
        //            telephoneNumber= 2648-2485},

        //    };

        //    return perros;
        //}
    }
}
