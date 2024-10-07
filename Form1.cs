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
                case "�������":
                    currentFactory = new RedFactory();
                    break;
                case "�����":
                    currentFactory = new BlueFactory();
                    break;
                case "������":
                    currentFactory = new YellowFactory();
                    break;
                case "�������":
                    currentFactory = new GreenFactory();
                    break;
                case "�����":
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
                MessageBox.Show("�������� ����.");
                return;
            }
            switch (comboBox2.SelectedItem.ToString())
            {
                case "�������":
                    currentShape = currentFactory.Createfigures();
                    break;
                case "�����":
                    currentShape = currentFactory.Createfigures();
                    break;
                case "������":
                    currentShape = currentFactory.Createfigures();
                    break;
                case "�������":
                    currentShape = currentFactory.Createfigures();
                    break;
                case "�����":
                    break;
            }
            panel1.Invalidate(); // �������������� ������
        }
    }
}
