using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Text.Json;

namespace PlannerTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //test class
    public class TestJson
    {
        //something about non-nullable and constructor values forcing the question mark, check after
        public string? LineA { get; set; }
        public string? LineB { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void BtnAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
            Trace.WriteLine("test");
        }

        private void BtnTestPrint_Click(object sender, RoutedEventArgs e)
        {
            //look into accessing variables and where to put them for wpf
            var myTest = new TestJson
            {
                LineA = "Hello",
                LineB = "World",
            };
            string jsonString = JsonSerializer.Serialize(myTest);
            Trace.WriteLine(jsonString);
            myTest.LineA = txtA.Text;
            myTest.LineB = txtB.Text;
            jsonString = JsonSerializer.Serialize(myTest);
            Trace.WriteLine(jsonString);
        }
    }
}