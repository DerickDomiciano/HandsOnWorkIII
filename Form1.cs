using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();

        }
        private void customizeDesign()
        {
            subMenuA.Visible = false;
            subMenuC.Visible = false;
            subMenuE.Visible = false;
            telaa.Visible = false;


        }
        private void hidesubMenu()
        {
            if (subMenuA.Visible == true)
                subMenuA.Visible = false;
            if (subMenuC.Visible == true)
                subMenuC.Visible = false;
            if (subMenuE.Visible == true)
                subMenuE.Visible = false;
            if (telaa.Visible == true)
                telaa.Visible = false;


        }
        private void showsubMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                hidesubMenu();
                subMenu.Visible = true;


            }
            else
                subMenu.Visible = false;

        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            showsubMenu(subMenuC); // mostra o menu suspenso dos clientes
            
        }

        private void btnacervo_Click(object sender, EventArgs e)
        {
            showsubMenu(subMenuA); // mostra o menu suspenso do acervo
        }

        private void btnemprestimo_Click(object sender, EventArgs e)
        {
            showsubMenu(subMenuE); // mostra o menu suspenso do empréstimo

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showsubMenu(telaa); // mostra o painel lateral

        }
    }
}
