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

            
        }

        private void btPerro_Click(object sender, EventArgs e)
        {
            Perro perro = new Perro();

            perro.setperroId(Convert.ToInt32(txBoxId.Text));
            perro.setName(txBoxName.Text);
            perro.setRaza(txBoxRaza.Text);
            perro.setAge(txBoxAge.Text);
            perro.setVacuna(txBoxVacuna.Text);
            perro.setOwnerName(txBoxownerName.Text);
            perro.setTelephoneNumber(txBoxTelefono.Text);

            lisBoxPerro.Items.Add(perro.getPerroGV());

            txBoxId.Text = "";
            txBoxName.Text = "";
            txBoxRaza.Text = "";
            txBoxAge.Text = "";
            txBoxVacuna.Text = "";
            txBoxownerName.Text = "";
            txBoxTelefono.Text = "";
           


        }
    }
}
    