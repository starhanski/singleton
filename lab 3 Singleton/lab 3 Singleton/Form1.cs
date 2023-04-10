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
            MessageBox.Show("Документів завантажено: " + documents.Count.ToString());
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Створюємо новий документ
            var document = new Document { Title = "Doc1", Content = "Lorem ipsum"};
            // Отримуємо репозиторій документів
            var repository = DocumentRepository.Instance;

            // Додаємо документ до репозиторію
            repository.Add(document);
            

        }
    }
}