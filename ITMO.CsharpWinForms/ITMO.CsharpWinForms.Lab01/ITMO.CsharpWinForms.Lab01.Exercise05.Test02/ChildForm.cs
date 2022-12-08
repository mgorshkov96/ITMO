namespace ITMO.CsharpWinForms.Lab01.Exercise05.Test02
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        // Делаем ChildForm в форме ромба
        private void ChildForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
                new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] 
            { 
                new Point(this.Width/2, 0),
                new Point(0, this.Height/2),
                new Point(this.Width/2, this.Height),
                new Point(this.Width, this.Height/2)
            });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}