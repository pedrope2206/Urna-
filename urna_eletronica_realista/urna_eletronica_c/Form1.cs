using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;


namespace urna_eletronica_c
{
    public partial class frmUm : Form
    {
        public frmUm()
        {
            InitializeComponent();
        }

        private void playSimpleSound()
        {
            System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();

            myPlayer.SoundLocation = @"E:\pasta_curso\desenvolvimento_de_sistemas\urna_eletronica_realista\sound\confirmsound.wav";

            myPlayer.Play();
        }

        private void playKeySound()
        {
            System.Media.SoundPlayer myPlayer2 = new System.Media.SoundPlayer();

            myPlayer2.SoundLocation = @"E:\pasta_curso\desenvolvimento_de_sistemas\urna_eletronica_realista\sound\tecla.wav";

            myPlayer2.Play();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnNumber1_Click(object sender, EventArgs e)
        {

            if (Class1.textoTeclado == "  ")
            {
                Class1.textoTeclado = "1";
                lblNCand.Text = Class1.textoTeclado;
            }
            

            else if (Class1.textoTeclado.Length == 1)
            {
                if (Class1.textoTeclado1 == "1" || Class1.textoTeclado1 == "2" || Class1.textoTeclado1 == "3" || Class1.textoTeclado1 == "4" || Class1.textoTeclado1 == "5" || Class1.textoTeclado1 == "6" || Class1.textoTeclado1 == "7" || Class1.textoTeclado1 == "8" || Class1.textoTeclado1 == "9" || Class1.textoTeclado1 == "0")
                {

                }
                else
                {
                    Class1.textoTeclado1 = "1";
                    lblNCand1.Text = Class1.textoTeclado1;
                }
            }
            if (lblNCand.Text == "5" && lblNCand1.Text == "1")
            {
                pctCandidatos.ImageLocation = @"E:\pasta_curso\desenvolvimento_de_sistemas\urna_eletronica_realista\Img\cachaçeira.jpeg";
                pctCandidatos.Visible = true;
                label6.Text = "Cachaçeira";
                label1.Text = "PGB" + "\n" + "(Bebidas da Grazi)";
            }
            playKeySound();
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {

            if (Class1.textoTeclado == "  ")
            {
                Class1.textoTeclado = "2";
                lblNCand.Text = Class1.textoTeclado;
            }

            else if (Class1.textoTeclado.Length == 1)
            {
                if (Class1.textoTeclado1 == "1" || Class1.textoTeclado1 == "2" || Class1.textoTeclado1 == "3" || Class1.textoTeclado1 == "4" || Class1.textoTeclado1 == "5" || Class1.textoTeclado1 == "6" || Class1.textoTeclado1 == "7" || Class1.textoTeclado1 == "8" || Class1.textoTeclado1 == "9" || Class1.textoTeclado1 == "0")
                {

                }
                else
                {
                    Class1.textoTeclado1 = "2";
                    lblNCand1.Text = Class1.textoTeclado1;
                }
            }

            if (lblNCand.Text == "1" && lblNCand1.Text == "2")
            {
                pctCandidatos.ImageLocation = @"E:\pasta_curso\desenvolvimento_de_sistemas\urna_eletronica_realista\Img\mini meçi.jpeg";
                pctCandidatos.Visible = true;
                label6.Text = "Mini Meçi";
                label1.Text = "PMME" + "\n" + "(Mini Meçi da Etec)";
            }
            else if (lblNCand.Text == "2" && lblNCand1.Text == "2")
            {
                pctCandidatos.ImageLocation = @"E:\pasta_curso\desenvolvimento_de_sistemas\urna_eletronica_realista\Img\jãozinho de cria.jpeg";
                pctCandidatos.Visible = true;
                label6.Text = "jãozinho de cria";
                label1.Text = "PG (Partido Gamer)";
            }
            playKeySound();
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            if (Class1.textoTeclado == "  ")
            {
                Class1.textoTeclado = "3";
                lblNCand.Text = Class1.textoTeclado;
            }

            else if (Class1.textoTeclado.Length == 1)
            {
                if (Class1.textoTeclado1 == "1" || Class1.textoTeclado1 == "2" || Class1.textoTeclado1 == "3" || Class1.textoTeclado1 == "4" || Class1.textoTeclado1 == "5" || Class1.textoTeclado1 == "6" || Class1.textoTeclado1 == "7" || Class1.textoTeclado1 == "8" || Class1.textoTeclado1 == "9" || Class1.textoTeclado1 == "0")
                {

                }
                else
                {
                    Class1.textoTeclado1 = "3";
                    lblNCand1.Text = Class1.textoTeclado1;
                }
            }
            playKeySound();
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            if (Class1.textoTeclado == "  ")
            {
                Class1.textoTeclado = "4";
                lblNCand.Text = Class1.textoTeclado;
            }

            else if (Class1.textoTeclado.Length == 1)
            {
                if (Class1.textoTeclado1 == "1" || Class1.textoTeclado1 == "2" || Class1.textoTeclado1 == "3" || Class1.textoTeclado1 == "4" || Class1.textoTeclado1 == "5" || Class1.textoTeclado1 == "6" || Class1.textoTeclado1 == "7" || Class1.textoTeclado1 == "8" || Class1.textoTeclado1 == "9" || Class1.textoTeclado1 == "0")
                {

                }
                else
                {
                    Class1.textoTeclado1 = "4";
                    lblNCand1.Text = Class1.textoTeclado1;
                }
            }

            if (Class1.textoTeclado1 == "4")
            {
                pctCandidatos.ImageLocation = @"E:\pasta_curso\desenvolvimento_de_sistemas\urna_eletronica_realista\Img\totonho_do_grau.jpeg";
                pctCandidatos.Visible = true;
                label6.Text = "totonho_do_grau";
                label1.Text = "PAPD (Secreto)";

            }
            playKeySound();
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            if (Class1.textoTeclado == "  ")
            {
                Class1.textoTeclado = "5";
                lblNCand.Text = Class1.textoTeclado;
            }

            else if (Class1.textoTeclado.Length == 1)
            {
                if (Class1.textoTeclado1 == "1" || Class1.textoTeclado1 == "2" || Class1.textoTeclado1 == "3" || Class1.textoTeclado1 == "4" || Class1.textoTeclado1 == "5" || Class1.textoTeclado1 == "6" || Class1.textoTeclado1 == "7" || Class1.textoTeclado1 == "8" || Class1.textoTeclado1 == "9" || Class1.textoTeclado1 == "0")
                {

                }
                else
                {
                    Class1.textoTeclado1 = "5";
                    lblNCand1.Text = Class1.textoTeclado1;

                    if (lblNCand.Text == "2" && lblNCand1.Text == "5")
                    {
                        pctCandidatos.ImageLocation = @"E:\pasta_curso\desenvolvimento_de_sistemas\urna_eletronica_realista\Img\Barão_biquinho.jpeg";
                        pctCandidatos.Visible = true;
                        label6.Text = "Barão" + "\n" + "Biquinho";
                        label1.Text = "BDE" + "\n" + "(Biquinhos da Etec)";
                    }

              
                }
                playKeySound();
            }

        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            if (Class1.textoTeclado == "  ")
            {
                Class1.textoTeclado = "6";
                lblNCand.Text = Class1.textoTeclado;
            }

            else if (Class1.textoTeclado.Length == 1)
            {
                if (Class1.textoTeclado1 == "1" || Class1.textoTeclado1 == "2" || Class1.textoTeclado1 == "3" || Class1.textoTeclado1 == "4" || Class1.textoTeclado1 == "5" || Class1.textoTeclado1 == "6" || Class1.textoTeclado1 == "7" || Class1.textoTeclado1 == "8" || Class1.textoTeclado1 == "9" || Class1.textoTeclado1 == "0")
                {

                }
                else
                {
                    Class1.textoTeclado1 = "6";
                    lblNCand1.Text = Class1.textoTeclado1;
                }
            }
            playKeySound();
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            if (Class1.textoTeclado == "  ")
            {
                Class1.textoTeclado = "7";
                lblNCand.Text = Class1.textoTeclado;
            }

            else if (Class1.textoTeclado.Length == 1)
            {
                if (Class1.textoTeclado1 == "1" || Class1.textoTeclado1 == "2" || Class1.textoTeclado1 == "3" || Class1.textoTeclado1 == "4" || Class1.textoTeclado1 == "5" || Class1.textoTeclado1 == "6" || Class1.textoTeclado1 == "7" || Class1.textoTeclado1 == "8" || Class1.textoTeclado1 == "9" || Class1.textoTeclado1 == "0")
                {

                }
                else
                {
                    Class1.textoTeclado1 = "7";
                    lblNCand1.Text = Class1.textoTeclado1;
                }
            }
            else if (lblNCand.Text == "1" && lblNCand1.Text == "7")
            {
                pctCandidatos.ImageLocation = @"E:\pasta_curso\desenvolvimento_de_sistemas\urna_eletronica_realista\Img\DinoAlexo.jpeg";
                pctCandidatos.Visible = true;
                label6.Text = "Dino Alexo";
                label1.Text = "PN (Partido" + "\n" + "dos nobres)";
            }
            playKeySound();
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            if (Class1.textoTeclado == "  ")
            {
                Class1.textoTeclado = "8";
                lblNCand.Text = Class1.textoTeclado;
            }

            else if (Class1.textoTeclado.Length == 1)
            {
                if (Class1.textoTeclado1 == "1" || Class1.textoTeclado1 == "2" || Class1.textoTeclado1 == "3" || Class1.textoTeclado1 == "4" || Class1.textoTeclado1 == "5" || Class1.textoTeclado1 == "6" || Class1.textoTeclado1 == "7" || Class1.textoTeclado1 == "8" || Class1.textoTeclado1 == "9" || Class1.textoTeclado1 == "0")
                {

                }
                else
                {
                    Class1.textoTeclado1 = "8";
                    lblNCand1.Text = Class1.textoTeclado1;
                }
            }

            if (lblNCand.Text  == "2" && lblNCand1.Text == "8")
            {
                pctCandidatos.ImageLocation = @"E:\pasta_curso\desenvolvimento_de_sistemas\urna_eletronica_realista\Img\jubsmabsgabs.jpeg";
                pctCandidatos.Visible = true;
                label6.Text = "jubsmabsgabs";
                label1.Text = "BBL (Secreto)";
            }
            playKeySound();
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            if (Class1.textoTeclado == "  ")
            {
                Class1.textoTeclado = "9";
                lblNCand.Text = Class1.textoTeclado;
            }

            else if (Class1.textoTeclado.Length == 1)
            {
                if (Class1.textoTeclado1 == "1" || Class1.textoTeclado1 == "2" || Class1.textoTeclado1 == "3" || Class1.textoTeclado1 == "4" || Class1.textoTeclado1 == "5" || Class1.textoTeclado1 == "6" || Class1.textoTeclado1 == "7" || Class1.textoTeclado1 == "8" || Class1.textoTeclado1 == "9" || Class1.textoTeclado1 == "0")
                {

                }
                else
                {
                    Class1.textoTeclado1 = "9";
                    lblNCand1.Text = Class1.textoTeclado1;
                }
            }

            if (Class1.textoTeclado1 == "9")
            {
                pctCandidatos.ImageLocation = @"E:\pasta_curso\desenvolvimento_de_sistemas\urna_eletronica_realista\";
                pctCandidatos.Visible = true;
            }
            playKeySound();
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            if (Class1.textoTeclado == "  ")
            {
                Class1.textoTeclado = "0";
                lblNCand.Text = Class1.textoTeclado;
            }

            else if (Class1.textoTeclado.Length == 1)
            {
                if (Class1.textoTeclado1 == "1" || Class1.textoTeclado1 == "2" || Class1.textoTeclado1 == "3" || Class1.textoTeclado1 == "4" || Class1.textoTeclado1 == "5" || Class1.textoTeclado1 == "6" || Class1.textoTeclado1 == "7" || Class1.textoTeclado1 == "8" || Class1.textoTeclado1 == "9" || Class1.textoTeclado1 == "0")
                {

                }
                else
                {
                    Class1.textoTeclado1 = "0";
                    lblNCand1.Text = Class1.textoTeclado1;
                }
            }

            if (lblNCand.Text == "0" && lblNCand1.Text == "0")
            {
                pctCandidatos.ImageLocation = @"E:\pasta_curso\desenvolvimento_de_sistemas\urna_eletronica_realista\Img\galã da meia noite.jpeg";
                pctCandidatos.Visible = true;
                label6.Text = "Galã da" + "\n" + "meia noite";
                label1.Text = "HPE (Homens" + "\n" + "de Preto da Etec)";
            }
            playKeySound();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            Class1.branco++;
            Class1.textoTeclado = "  ";
            Class1.textoTeclado1 = "  ";
            lblNCand.Text = Class1.textoTeclado;
            lblNCand1.Text = Class1.textoTeclado1;
            Class1.eleitores++;
            playSimpleSound();
        }

        private void tOTALDEVOTOSAPURADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String senha = Interaction.InputBox("Informe a senha", "Senha");
            if (senha == "21006")
            {
                MessageBox.Show($"Boletim virtual de urna:" + "\n" + $"Votos Brancos: {Class1.branco}" + "\n" + $"Votos nulos: {Class1.nulo}" + "\n" + $"Barão Biquinho: {Class1.Barao_biquinho}" + "\n" + $"Cachaceira: {Class1.Cachaceira}" + "\n" + $"Dino Alexo: {Class1.Dino_alexo}" + "\n" + $"Galã da meia noite: {Class1.gala}" + "\n" + $"Joãozinho de Cria: {Class1.joazinho}" + "\n" + $"JubsMabsGabs: {Class1.jubs}" + "\n" + $"Mini meçi: {Class1.mini_messi}" + "\n" + $"Totonho do Grau: {Class1.totonho}");

            }
            else
            {
                MessageBox.Show("A senha esta incorreta", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void cANDIDATOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCandidatos candidatos = new frmCandidatos();
            candidatos.ShowDialog();
            Dispose();
        }

        private void btnCorrige_Click_1(object sender, EventArgs e)
        {
            Class1.textoTeclado = "  ";
            Class1.textoTeclado1 = "  ";
            lblNCand.Text = Class1.textoTeclado;
            lblNCand1.Text = Class1.textoTeclado1;
            label1.Text = "                   ";
            label6.Text = "                   ";
            pctCandidatos.Visible = false;
            pictureBox2.Visible = false;
        }

        private void oPÇÕESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String senha = Interaction.InputBox("Informe a senha", "Senha");
            if (senha == "21006")
            {
                MessageBox.Show($"Boletim virtual de urna:" + "\n" + $"Votos Brancos: {Class1.branco}" + "\n" + $"Votos nulos: {Class1.nulo}" + "\n" + $"Barão Biquinho: {Class1.Barao_biquinho}" + "\n" + $"Cachaceira: {Class1.Cachaceira}" + "\n" + $"Dino Alexo: {Class1.Dino_alexo}" + "\n" + $"Galã da meia noite: {Class1.gala}" + "\n" + $"Joãozinho de Cria: {Class1.joazinho}" + "\n" + $"JubsMabsGabs: {Class1.jubs}" + "\n" + $"Mini meçi: {Class1.mini_messi}" + "\n" + $"Totonho do Grau: {Class1.totonho}");

            }
            else
            {
                MessageBox.Show("A senha esta incorreta", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (lblNCand.Text == "2" && lblNCand1.Text == "5")
            {
                Class1.Barao_biquinho++;
                Class1.textoTeclado1 = "  ";
                lblNCand.Text = Class1.textoTeclado;
                lblNCand1.Text = Class1.textoTeclado1;
                label1.Text = "                   ";
                label6.Text = "                   ";
                pictureBox2.Visible = true;
                

            }
            else if (lblNCand.Text == "5" && lblNCand1.Text == "1")
            {
                Class1.Cachaceira++;
                Class1.textoTeclado = "  ";
                Class1.textoTeclado1 = "  ";
                lblNCand.Text = Class1.textoTeclado;
                lblNCand1.Text = Class1.textoTeclado1;
                label1.Text = "                   ";
                label6.Text = "                   ";
                pctCandidatos.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (lblNCand.Text == "1" && lblNCand1.Text == "7")
            {
                Class1.Dino_alexo++;
                Class1.textoTeclado = "  ";
                Class1.textoTeclado1 = "  ";
                lblNCand.Text = Class1.textoTeclado;
                lblNCand1.Text = Class1.textoTeclado1;
                label1.Text = "                   ";
                label6.Text = "                   ";
                pctCandidatos.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (lblNCand.Text == "4" && lblNCand1.Text == "7")
            {
                Class1.gala++;
                Class1.textoTeclado = "  ";
                Class1.textoTeclado1 = "  ";
                lblNCand.Text = Class1.textoTeclado;
                lblNCand1.Text = Class1.textoTeclado1;
                label1.Text = "                   ";
                label6.Text = "                   ";
                pctCandidatos.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (lblNCand.Text == "2" && lblNCand1.Text == "2")
            {
                Class1.joazinho++;
                Class1.textoTeclado = "  ";
                Class1.textoTeclado1 = "  ";
                lblNCand.Text = Class1.textoTeclado;
                lblNCand1.Text = Class1.textoTeclado1;
                label1.Text = "                   ";
                label6.Text = "                   ";
                pctCandidatos.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (lblNCand.Text == "2" && lblNCand1.Text == "8")
            {
                Class1.jubs++;
                Class1.textoTeclado = "  ";
                Class1.textoTeclado1 = "  ";
                lblNCand.Text = Class1.textoTeclado;
                lblNCand1.Text = Class1.textoTeclado1;
                label1.Text = "                   ";
                label6.Text = "                   ";
                pctCandidatos.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (lblNCand.Text == "1" && lblNCand1.Text == "2")
            {
                Class1.mini_messi++;
                Class1.textoTeclado = "  ";
                Class1.textoTeclado1 = "  ";
                lblNCand.Text = Class1.textoTeclado;
                lblNCand1.Text = Class1.textoTeclado1;
                label1.Text = "                   ";
                label6.Text = "                   ";
                pctCandidatos.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (lblNCand.Text == "7" && lblNCand1.Text == "4")
            {
                Class1.totonho++;
                Class1.textoTeclado = "  ";
                Class1.textoTeclado1 = "  ";
                lblNCand.Text = Class1.textoTeclado;
                lblNCand1.Text = Class1.textoTeclado1;
                label1.Text = "                   ";
                label6.Text = "                   ";
                pctCandidatos.Visible = false;
                pictureBox2.Visible = true;
            }
            else
            {
                Class1.nulo++;
                pictureBox2.Visible = true;
            }
            playSimpleSound();
       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}

