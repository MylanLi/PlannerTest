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
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace PlannerTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        DayData myTestItem;
        public MainWindow()
        {
            InitializeComponent();
            myTestItem = new DayData { LineA = "Hello", LineB = "World" };
        }

        /*
        public static void Main()
        {
            
        }
        */

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
            
            string jsonString = JsonSerializer.Serialize(myTestItem);
            Trace.WriteLine(jsonString);
            myTestItem.LineA = txtA.Text;
            myTestItem.LineB = txtB.Text;
            jsonString = JsonSerializer.Serialize(myTestItem);
            Trace.WriteLine(jsonString);
        }
    }
}