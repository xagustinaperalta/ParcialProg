using BibliotecaDeClases;

namespace FormularioParcial2
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }


        private void btoIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            int edad = (int)nupEdad.Value;
            string cuit = mtbCUIT.Text.Trim();

            try
            {
                Funciones.ValidaCuit(cuit);
                string genero = "";
                if (rbFemenino.Checked) genero = rbFemenino.Text.Trim();
                if (rbMasculino.Checked) genero = rbMasculino.Text.Trim();
                if (rbNoBinario.Checked) genero = rbNoBinario.Text.Trim();

                string c1 = chkc.Checked ? chkc.Text.Trim() : "";
                string c2 = chkCplus.Checked ? chkCplus.Text.Trim() : "";
                string c3 = chkJavaScript.Checked ? chkJavaScript.Text.Trim() : "";

                string[] curso = new string[3];
                if (c1 == "" && c2 == "" && c3 == "")
                {
                    MessageBox.Show("Seleccione una opción para curso");
                }
                else
                {
                    curso[0] = c1;
                    curso[1] = c2;
                    curso[2] = c3;
                }

                string pais = lbPais.Text.Trim();

                Ingresante ing = new Ingresante(nombre, direccion, edad, cuit, genero, pais, curso);

                if (mConsulta(this, "Datos Ingresante \n" + ing.Mostrar()))
                {
                    if (MessageBox.Show(ing.MostrarCursos(), "Cursos Inscripto", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        List<string>listaMensajes=new List<string>();
                        listaMensajes=ing.Guardar();
                        MessageBox.Show(string.Join("\n", listaMensajes));
                        this.Vaciar();
                    }
                    else
                    {
                        MessageBox.Show("verifique los datos e intente nuevamente");
                    }

                }
                else
                {
                    MessageBox.Show("Datos Descartados");

                    this.Vaciar();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static bool mConsulta(Form actual, string mensaje)
        {
            if (MessageBox.Show(actual, mensaje, "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal void Vaciar()
        {
            txtDireccion.Text = "";
            txtNombre.Text = "";
            nupEdad.Value = 18;
            mtbCUIT.Text = "";
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbNoBinario.Checked = false;
            chkc.Checked = false;
            chkCplus.Checked = false;
            chkJavaScript.Checked = false;
            lbPais.Text = "";
        }
    }
}
