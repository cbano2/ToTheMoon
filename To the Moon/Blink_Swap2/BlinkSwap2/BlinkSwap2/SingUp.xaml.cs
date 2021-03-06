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
        
        
        public SingUp()
        {
            InitializeComponent();
            
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Tranferencia transferencia = new Tranferencia();
            Store store = new Store();
            store.User = txtUser.Text;
            store.Ruc = txtRuc.Text;
            store.Wallet = TxtWallet.Text;
            store.Email = TxtEmail.Text;
            store.Amount = 0;
            transferencia.mostrarTienda(store);
            MessageBox.Show("Se guardo correctamente el usuario");
            Swap swap = new Swap();
            this.Hide();
            Programa programa = new Programa();
            programa.Show();
            
           
            

        }
    }
}
