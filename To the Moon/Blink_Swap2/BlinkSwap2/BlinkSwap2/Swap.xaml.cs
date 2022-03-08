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
    /// Lógica de interacción para Swap.xaml
    /// </summary>
    public partial class Swap : Window
    {
        public Swap()
        {
            InitializeComponent();
            List<Monedas> ListaMonedas = new List<Monedas>();
            ListaMonedas.Add(new Monedas { NombreMonedas="Btc"});
            ListaMonedas.Add(new Monedas { NombreMonedas = "Solana" });
            ListaMonedas.Add(new Monedas { NombreMonedas = "Eth" });
            Moneda.ItemsSource= ListaMonedas;
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtRuc_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario();
            Transaccion transaccion = new Transaccion();
            String total;
            total=txtTotal.Text;
            usuario.Name=txtUser.Text;
            usuario.Wallet=TxtWallet.Text;
            usuario.Email=TxtEmail.Text;
            usuario.Cedula = txtCed.Text;
            usuario.Amount = Convert.ToDouble(txtTotal.Text);
            MessageBox.Show("Se ha realizado de forma correcta la conversión y transferencia");
            
             
        }
     
        public class Monedas
        {
            public string NombreMonedas { get; set; }

        }
    }
}
