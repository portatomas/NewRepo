using Microsoft.VisualBasic.Devices;

namespace simulacro_de_parcial_1._0
{
    public partial class Form1 : Form
    {
        double altura;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            var generatriz=double.Parse(txtaltura.Text);
            var altura = double.Parse(txtaltura.Text);
            var radio = double.Parse(txtradio.Text);
            var area = calculararea(generatriz, radio);
            var volumen = calcularvolumen(generatriz, radio);
            DialogResult DialogResult = MessageBox.Show($"el resultado del area es {area} y el resultado del volumen es {volumen}");
        }

        private object calcularvolumen(double generatriz, double radio)
        {
            return (Math.PI * Math.Pow(radio, 2) * altura) / 3;
        }

        private object calculararea(double generatriz, double radio)
        {
            return (int)(Math.PI * radio * (radio + generatriz));
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" fin del programa", "salir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtgeneratriz.Clear();
            txtaltura.Clear();
            txtradio.Clear();
            txtgeneratriz.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿desea salir del formulario?",
              "pregunta",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;// cancela el evento de cierre del form
            }
        }

        private void textaltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}