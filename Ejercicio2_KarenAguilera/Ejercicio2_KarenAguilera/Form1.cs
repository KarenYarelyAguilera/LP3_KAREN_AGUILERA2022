using System.Collections;

namespace Ejercicio2_KarenAguilera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
            }
            

        }
        string[] nombre;
        int[] edad;
        int datos;




        private void GuardarNombre_btn_Click(object sender, EventArgs e)

        {
            if (numerodatos_txt.Text.Trim() != "")
            {
                datos = int.Parse(numerodatos_txt.Text.Trim());
                nombre = new string[datos];
                edad = new int[datos];
                for (int i = 0; i < datos; i++)
                {


                    nombre[i] = Nombre_txt.Text;
                    edad[i] = Convert.ToInt32(Edad_txt.Text);
                    datos_cb.Items.Add("Nombre: " + nombre[i] + "  Edad: " + edad[i]);

                }




            }
          

        }

        private void Limpiar_btn_Click(object sender, EventArgs e)
        {
            Edad_txt.Clear();
            Nombre_txt.Clear();
            numerodatos_txt.Clear();
        }

        private void Salir_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    







    