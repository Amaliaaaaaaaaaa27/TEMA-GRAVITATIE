using System.CodeDom;
using System.Windows.Forms;



namespace TEMA_GRAVITATIE
{

    public partial class Form1 : Form
    {
        public string nume { get; private set; }
        public double greutate { get; private set; }

        const float gravitatie_luna = 0.16f;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private double CalculeazaGreutateLuna(double greutate)
        {
            return greutate * gravitatie_luna;
        }

        private void btn_Calculeaza_Click(object sender, EventArgs e)
        {
            nume = textBox_Nume.Text;

            if (double.TryParse(textBox_Greutate.Text, out double greutate))
            {
                double greutatePeLuna = (float)CalculeazaGreutateLuna(greutate);

                label2.Text = $"Numele este {this.textBox_Nume.Text} . \n Iar greutatea sa pe Luna este {greutatePeLuna} kg";
            }
            else
            {
                label2.Text = $"Introduce ti o greutate valida ";
            }

        }

        private void textBox_Nume_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Luni_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Ani_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Zile_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Stergere_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_baraSus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Greutate_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
