namespace ProjectIU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnBireysel_Click(object sender, EventArgs e)
        {
            grbBireysel.Visible = true;
            grbKurumsal.Visible = false;
        }

        private void btnKurumsal_Click(object sender, EventArgs e)
        {
            grbKurumsal.Visible=true;
            grbBireysel.Visible=false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grbKurumsal.Visible = false;
            grbBireysel.Visible=false;
        }
    }
}
