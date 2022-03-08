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
    /// Lógica de interacción para Tranferencia.xaml
    /// </summary>
    public partial class Tranferencia : Window
    {
        public Tranferencia()
        {
            InitializeComponent();
            
        }
        public void mostrarTienda(Store store)
        {
            txtWalletTienda.Text = store.Wallet;

        }
        public void mostrarUsuario(Usuario usuario, Swap.Monedas ListaMonedas)
        {
            
            txtWalletUsuario.Text = usuario.Wallet;
            txtNombre.Text = usuario.Name;
            TxtTotal.Text = Convert.ToString(usuario.Amount);
            TxtMoneda.Text = ListaMonedas.NombreMonedas;
            


        }
        

        
    }
}
