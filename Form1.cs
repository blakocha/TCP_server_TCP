using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net; 

namespace TCP_server_TCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpListener serwer = null; 
        private TcpClient klient = null; 

        private void Button_Start_Click(object sender, EventArgs e)
        {
            IPAddress adresIP = null; 

            try
            {
                adresIP=IPAddress.Parse(Adres.Text);
            }

            catch
            {
                MessageBox.Show("Błędny format adresu IP: " + Adres.Text, "Błąd");
           
                Adres.Text = string.Empty;
                return; 
            }

            /* int port = Convert.ToInt32(PortNumber.Value);*/
            int port = Convert.ToUInt16(PortNumber.Value);
            
            try
            {
                serwer = new TcpListener(adresIP, port);
                serwer.Start();
                klient = serwer.AcceptTcpClient();

                info_o_polaczeniu.Items.Add("Nawiązano połączenie. ");

                Button_Start.Enabled = false;
                Button_Stop.Enabled = true;
                klient.Close();
                serwer.Stop();

                klient = serwer.AcceptTcpClient();

            }

            catch (Exception ex)
            {
                info_o_polaczeniu.Items.Add("Błąd inicjalizacji serwera. ");
                MessageBox.Show(ex.ToString(), "Błąd"); 
            }




        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            serwer.Stop();
            klient.Close();
            info_o_polaczeniu.Items.Add("Zakończono pracę serwera. ");
            Button_Start.Enabled = true;
            Button_Stop.Enabled = false;  
        }
    }
}
