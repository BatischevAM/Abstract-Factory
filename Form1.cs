using System.Windows.Forms;

namespace Abstract_Factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IShapeFactory currentFactory;
        private IShape currentShape;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Красный":
                    currentFactory = new RedFactory();
                    break;
                case "Синий":
                    currentFactory = new BlueFactory();
                    break;
                case "Желтый":
                    currentFactory = new YellowFactory();
                    break;
                case "Зеленый":
                    currentFactory = new GreenFactory();
                    break;
                case "Белый":
                    break;
            }
            currentShape = null;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            currentShape?.Draw(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentFactory == null)
            {
                MessageBox.Show("Выберите цвет.");
                return;
            }
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Красный":
                    currentShape = currentFactory.Createfigures();
                    break;
                case "Синий":
                    currentShape = currentFactory.Createfigures();
                    break;
                case "Желтый":
                    currentShape = currentFactory.Createfigures();
                    break;
                case "Зеленый":
                    currentShape = currentFactory.Createfigures();
                    break;
                case "Белый":
                    break;
            }
            panel1.Invalidate(); // Перерисовываем панель
        }
    }
}
