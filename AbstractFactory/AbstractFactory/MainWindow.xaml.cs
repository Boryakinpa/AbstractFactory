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

namespace AbstractFactory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AbstractFactrory abstractFactrory;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxColors.SelectedItem != null)
            {
                string selectedColor = ComboBoxColors?.SelectedItem is ComboBoxItem selectedItem ? (string)selectedItem.Content : "";
                GridSimple.Children.Clear();
                if (selectedColor == "Red")
                {
                    abstractFactrory = new RedFactory(GridSimple);
                    abstractFactrory.CreateProductCircle();
                    abstractFactrory.CreateProductTriangle();
                    abstractFactrory.CreateProductSquare();
                }
                if (selectedColor == "Green")
                {
                    abstractFactrory = new GreenFactory(GridSimple);
                    abstractFactrory.CreateProductCircle();
                    abstractFactrory.CreateProductTriangle();
                    abstractFactrory.CreateProductSquare();
                }
                if (selectedColor == "Blue")
                {
                    abstractFactrory = new BlueFactory(GridSimple);
                    abstractFactrory.CreateProductCircle();
                    abstractFactrory.CreateProductTriangle();
                    abstractFactrory.CreateProductSquare();
                }
            }
        }
    }
}