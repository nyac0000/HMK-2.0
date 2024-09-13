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
using static System.Net.Mime.MediaTypeNames;

namespace HMK_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            bool isEverythingGood = true;

            if (string.IsNullOrWhiteSpace(txt_City.Text) == true) ;
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid city!");
            }

            if (string.IsNullOrWhiteSpace(txt_FirstName.Text) == true) ;
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a first name!");
            }

            double gpa;

            if (double.TryParse(txt_GPA.Text, out gpa) == false)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid first name!");
            }

            if (string.IsNullOrWhiteSpace(txt_LastName.Text) == true);
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a last name!");
            }

            if (string.IsNullOrWhiteSpace(txt_Major.Text) == true);
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid major!");
            }

            if (string.IsNullOrWhiteSpace(txtState.Text) == true) ;
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid state!");
            }

            if (string.IsNullOrWhiteSpace(txt_StreetName .Text) == true);
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid streetName!");
            }

            if (string.IsNullOrWhiteSpace(txt_StreetName.Text) == true) ;
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid streetName!");
            }

            int streetNumber, zipcode;

            if (int.TryParse(txt_StreetNumber.Text,out streetNumber) == false)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid first name!");
            }

            if (int.TryParse(txt_Zipcode.Text, out zipcode) == false)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid street name!");
            }

            if (isEverythingGood == false)
            {
                return;
            }

            Student student = new Student()
            {
                FirstName = txt_FirstName.Text,
                GPA = gpa,
                LastName = txt_LastName.Text,
                Major = txt_Major.Text

            };
            student.SetAddress(streetNumber, txt_StreetName.Text,txtState.Text, txt_City.Text, zipcode);

           GraduationHandout.Items.Add(student);

            txt_City.Clear();
            txt_FirstName.Clear();
            txt_LastName.Clear();
            txt_GPA.Clear();
            txt_Major.Clear();
            txt_LastName.Clear();
            txt_StreetNumber.Clear();
            txt_Zipcode.Clear();
            txt_StreetNumber.Clear();
           // txt_state.Clear();
        }
      
    }
}