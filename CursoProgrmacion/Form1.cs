namespace CursoProgrmacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre;

            float peso, resultado, altura;
            const string infomacion = "su estado esta en :";
            if (txtNombre.Text.Length == 0)
            {

                txtNombre.Focus();
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "No dejar el campo del nombre vació";
                throw new Exception();
            }
            else if (txtPeso.Text.Length == 0)
            {
                txtPeso.Focus();
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "No dejar el campo del peso vació";
                throw new Exception();

            }
            else if (txtAltura.Text.Length == 0)
            {
                txtPeso.Focus();
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "No dejar el campo del altura vació";
                throw new Exception();
            }

            nombre = txtNombre.Text.Trim();
            peso = Convert.ToSingle(txtPeso.Text);
            altura = Convert.ToSingle(txtAltura.Text);


            if (peso > 255)
            {
                txtPeso.Focus();
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "EL peso no pude ser mayor 255K";
                throw new Exception();
            }

            if (altura > 255)
            {
                txtPeso.Focus();
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "La añtura no puede ser mayor 255 M";
                throw new Exception();
            }


            resultado = peso / (altura * altura);
            float al = altura * altura;
            lblResultado.ForeColor = Color.Black;
            if (resultado <= 18.5)
            {
                lblResultado.Text = nombre + infomacion + " Bajo peso";
                lblResultado.ForeColor = Color.Yellow;
            }
            else if (resultado > 18.5 && resultado <= 24.9)
            {
                lblResultado.Text = nombre + infomacion + " Normal";
                lblResultado.ForeColor = Color.Green;
            }
            else if (resultado >= 25.0 && resultado <= 29.9)
            {
                lblResultado.Text = nombre + infomacion + " Sobrepeso";
                lblResultado.ForeColor = Color.Yellow;
            }
            else
            {
                lblResultado.Text = nombre + infomacion + " Obesidad";
                lblResultado.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("En el campo de altura se colocaria ,  en vez de . ejemplo: en vez de colocar 1.78 coloca 1,78  ", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}