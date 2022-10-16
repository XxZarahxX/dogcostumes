namespace CostumeShopy
{
    public partial class Form1 : Form
    {
        List<Costume> jelmezek = new List<Costume>();
        Costume lawDoge = new Costume(1, "Abide The Law Doge Costume", "L", 60, false);
        Costume clownDoge = new Costume(2, "Happy Clown Doge Costume", "M", 55, false);
        Costume gnomeDoge = new Costume(3, "Garden Gnome Good Boy Costume", "S", 56, false);       
        string add = string.Empty;
        public Form1()
        {
            InitializeComponent();
            GetCostume();
            jelmezek.Add(lawDoge);
            jelmezek.Add(clownDoge);
            jelmezek.Add(gnomeDoge);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}