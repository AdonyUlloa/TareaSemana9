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
        private string _age;
        private string _vacuna;


        public string _ownerName; /*{ get; set; }*/
        public string _telephoneNumber; /*{ get; set; }*/


        //metodo constructor 
        //sobre carga de metodo constructor
        public Perro()//metodo constrctor vacio
        { }

        //metodo constructor
        public Perro(int perroId, string name, string raza, string age, string vacuna, string ownerName, string telephoneNumber)
        {
            _perroId = perroId;
            _name = name;
            _raza = raza;
            _age = age;
            _vacuna = vacuna;
            _ownerName = ownerName;
            _telephoneNumber = telephoneNumber;

        }

        public Perro(String name)
        {
            _name = name;
        }


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

        public void setAge(string age)
        {
            _age = age;
        }
        public string getAge()
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

        //Metodos
        public string getPerroInfo()
        {
            return _perroId + " " + _name + " " + _raza + " " + _age + " " + _vacuna + " " +
                _ownerName + " " + _telephoneNumber;
        }

        public string getPerroGV()
        {
            return " ID: " + _perroId + " | NOMBRE PERRO: " + _name + " | RAZA: " + _raza + " | EDAD: " +
                _age + " | VACUNAS: " + _vacuna + " | NOMBRE DEL DUEÑO: " + _ownerName + " | NUMERO CONTACTO: " + _telephoneNumber;


        }


        public void setOwnerName(string ownerName)
        {
            _ownerName = ownerName;
        }
        public string getOwnerName()
        {
            return _ownerName;
        }

        public void setTelephoneNumber(string telephoneNumber)
        {
            _telephoneNumber = telephoneNumber;
        }

        public string getTelephoneNumber()
        {
            return _telephoneNumber;
        }





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
