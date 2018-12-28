using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Bitmap foto;     // declaração global, no form

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // filtro com extensões de ficheiros a mostrar na Dialog box 
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Filter =
        "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";

            openFileDialog1.Title = "Selecione Imagem";       // título | header da Dialog box 
            DialogResult dr = openFileDialog1.ShowDialog();   //  criar uma instancia da Dialog box
            if (dr == DialogResult.OK)                        // Verificar em que botão o utilizador clicou. Se OK...
            {
                 pictureBox1.Image = new Bitmap (openFileDialog1.FileName);     // cria imagem (Bitmap) com  a imagem 
               
            }                                                                  // selecionada, e coloca na pictureBox

            openFileDialog1.Dispose();                                         // apaga a instância da Dialog box

           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // cria bitmap com nome do ficheiro
            foto = new Bitmap(openFileDialog1.FileName);
            foto.Save("C:\\ESMAD\\img1.jpg");
        }
    }
}
