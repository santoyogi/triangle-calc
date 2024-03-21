namespace TriangleCalculatorWindows
{
    public partial class frmTriangle : Form
    {
        public frmTriangle()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double sideA, sideB, hypotenuse, area;

            sideA = double.Parse(txtSideA.Text);
            sideB = double.Parse(txtSideB.Text);

            triangleStats ts = new triangleStats(sideA, sideB);
            hypotenuse = ts.GetHypotenuse();
            area = ts.GetArea();

            lblHypotenuse.Text = "Hypotenuse: " + hypotenuse;
            lblArea.Text = "Area: " + area;
        }
    }
}