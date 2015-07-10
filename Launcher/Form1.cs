using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
        public partial class Launcher : Form
        {
            int TogMove;
            int MValX;
            int MValY;

            public Launcher()
            {
                InitializeComponent();
            }



            private void pictureBox1_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {

                this.WindowState = FormWindowState.Minimized;
            }

            private void Launcher_Load(object sender, EventArgs e)
            {

            }

            private void Launcher_MouseDown(object sender, MouseEventArgs e)
            {
                TogMove = 1;
                MValX = e.X;
                MValY = e.Y;
            }

            private void Launcher_MouseUp(object sender, MouseEventArgs e)
            {
                TogMove = 0;
            }

            private void Launcher_MouseMove(object sender, MouseEventArgs e)
            {
                if (TogMove == 1)
                {
                    this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
                }

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void Minimized_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;

            }

            private void Close_Click(object sender, EventArgs e)
            {
                Close();

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void Noticias_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
            {

            }

            private void img_email_Click(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox1_MouseClick(object sender, MouseEventArgs e)
            {
                if (textBox1.Text == "Login")
                {
                    textBox1.Text = "";
                }
                else
                {

                }


                Background1.BackColor = SystemColors.ButtonFace;
                fillet1.BackColor = Color.SteelBlue;

                //background2.BackColor = SystemColors.ButtonHighlight;
                fillet2.BackColor = Color.Transparent;

                background2.BorderStyle = BorderStyle.None;
                fillet2.BorderStyle = BorderStyle.None;
            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox2_MouseClick(object sender, MouseEventArgs e)
            {
                if (textBox2.Text == "Senha")
                {
                    textBox2.Text = "";
                    textBox2.UseSystemPasswordChar = true;
                }
                else
                {

                }



                background2.BackColor = SystemColors.ButtonFace;
                fillet2.BackColor = Color.SteelBlue;

                //Background1.BackColor = SystemColors.ButtonHighlight;
                fillet1.BackColor = Color.Transparent;

                Background1.BorderStyle = BorderStyle.None;
                fillet1.BorderStyle = BorderStyle.None;
            }

            private void button1_Click(object sender, EventArgs e)
            {

            }

            private bool ValidaUsuario(string login, string password)
            {
                //variável que será testada para
                //informar o retorno
                int retorno = -1;
                ////instância da conexão
                MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=ragnarok; Uid=ragnarok; Pwd=ragnarok");
                //comando sql que dá um count 
                //na tabela se existirem usuario e senha
                //com os dados informados
                string comando = "SELECT COUNT(*) FROM login WHERE userid=@login AND user_pass=@password";
                //instância do comando
                MySqlCommand cmd = new MySqlCommand(comando, conn);
                //preenchimento dos parâmetros
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);
                //abro conexão
                conn.Open();
                //retorno recebe o resultado do execute scalar
                retorno = Convert.ToInt32(cmd.ExecuteScalar());
                //fecho conexão
                conn.Close();
                //retorno true se retorno for maior que zero
                return retorno > 0;
            }


            private void Login_Start_Click(object sender, EventArgs e)
            {

                // reseta campos ////////////////////////////////////////////////////////////////////////////

                label9.Visible = false;
                //progressBar1.Value = 0;

                /////////////////////////////////////////////////////////////////////////////////////////////





                if (ValidaUsuario(textBox1.Text, textBox2.Text))
                {

                    string ExeType = "1rag1";
                    string usuario = textBox1.Text;
                    string senha = textBox2.Text;

                    string output = String.Format("-t:{0} {1} {2}", senha, usuario, ExeType);

                    Process.Start("CLambeRO.exe", output);
                }
                else
                {
                    //  AÇÃO AO ERRO DE LOGIN //////////////////////////////////////////////////////////////////

                    label9.Text = "Usuário ou senha invalidos";
                    label9.Visible = true;
                    textBox1.Text = "";
                    textBox2.Text = "";

                    ////////////////////////////////////////////////////////////////////////////////////////////
                }


            }

            private void label9_Click(object sender, EventArgs e)
            {

            }

            private void Login_Start_Off_Click(object sender, EventArgs e)
            {

            }

        }
    }

