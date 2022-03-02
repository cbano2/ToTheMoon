using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BlinkSwap2
{
    /// <summary>
    /// Lógica de interacción para SingUp.xaml
    /// </summary>
    public partial class SingUp : Window
    {
        Store store = new Store();
        public SingUp()
        {
            InitializeComponent();
            
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            store.User = txtUser.Text;
            store.Ruc = txtRuc.Text;
            store.Wallet = TxtWallet.Text;
            store.Email = TxtEmail.Text;
            store.Amount = 0;
            MessageBox.Show("Se guardo correctamente el usuario");

            this.Hide();
            Programa programa = new Programa();
            programa.Show();
            

        }
    }
}
