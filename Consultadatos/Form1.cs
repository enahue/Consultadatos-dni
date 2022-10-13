using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultadatos.apiRest;





namespace Consultadatos
{
    public partial class Form1 : Form
    {
        apidb dBApi = new apidb();
        
        public Form1()
        {
            InitializeComponent();
            

        }

        
        public  void rconsulta()
        {
            txb_rdni.Text = "";
            
            try
            {
                
                dynamic respuesta = dBApi.Get("https://api.apis.net.pe/v1/dni?numero=" + textBox1.Text + "");
                txb_rdni.Text = respuesta.nombre.ToString();

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                
                
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

               
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 8)
            { this.txb_rdni.Focus();
                rconsulta();

            }

           
        }
    }
}
