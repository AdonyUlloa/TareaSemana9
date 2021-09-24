using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_semana_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instacia de la clase Perro
            Perro perro = new Perro();

            //creamos un objeto perro
            perro.setperroId(1);
            perro.setName(" Roky");

            //mostrar datos de perro
            //GET
            MessageBox.Show(perro.getperroId() + perro.getName());

            //MEDIATE PROPIEDA ATOCOMPLEMENTADA
            //SET
            perro._ownerName = "0001";


            //GET
            MessageBox.Show(perro._ownerName);

        }

       
    }
}
