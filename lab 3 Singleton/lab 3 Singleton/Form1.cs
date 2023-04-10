using System.Reflection.Metadata;
using System.Xml.Linq;

namespace lab_3_Singleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      


        private void button2_Click_1(object sender, EventArgs e)
        {
            var repository = DocumentRepository.Instance;
            var documents = repository.GetAll();
            MessageBox.Show("��������� �����������: " + documents.Count.ToString());
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // ��������� ����� ��������
            var document = new Document { Title = "Doc1", Content = "Lorem ipsum"};
            // �������� ���������� ���������
            var repository = DocumentRepository.Instance;

            // ������ �������� �� ����������
            repository.Add(document);
            

        }
    }
}