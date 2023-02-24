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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReneUtiles;
using ReneUtiles.Clases;
using ReneUtiles.Clases.WPF;

using Delimon.Win32.IO;
namespace VerTokenSeguridad_Actualice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ManagerSelectionIndex mng_SI_discos;
        private bool seInicio=false;
        public MainWindow()
        {
            InitializeComponent();

            mng_SI_discos = new ManagerSelectionIndex(alSeleccionar_CB_Discos, CB_Discos_Conectados);

            TB_Token.Text = UtilesEncriptar.getSHA256(UtilesHardware.GetMotherBoardID());
            copiarTOKEN_alPortapapeles();

            string urlActual = System.IO.Directory.GetCurrentDirectory();
            urlActual = Utiles.remplazarAlfinal(urlActual, "",@"\bin\Debug");//, @"\Debug", @"\VerTokenSeguridad_Actualice\Debug"
            //urlRelativa: VerTokenSeguridad_Actualice\bin\Debug
            DirectoryInfo carpetaActual = new DirectoryInfo(urlActual);
            carpetaActual = carpetaActual.Parent != null ? carpetaActual.Parent : carpetaActual;
            TB_Direccion_Del_TXT.Text = carpetaActual.ToString();

            CB_Discos_Conectados.ItemsSource= Directory.GetLogicalDrives();

            selecionarDiscoExistenteDe_direccionCarpeta();

            DateTime dt = DateTime.Now;
            TB_Nombre_del_txt.Text="TOKEN_ACTUALIZE_"+dt.Year+"-"+dt.Month+"-"+dt.Day+"__"+dt.Hour+"-"+dt.Minute+"-"+dt.Second+"-"+dt.Millisecond;

            TB_Direccion_Del_TXT.KeyUp += (o, e) =>
            {
                selecionarDiscoExistenteDe_direccionCarpeta();
                comprobarExistenciaYCambiarColor();
            };

            comprobarExistenciaYCambiarColor();
            seInicio = true;

        }
        private bool existeCarpetaEnTB() {
            try
            {
                return new DirectoryInfo(TB_Direccion_Del_TXT.Text).Exists;
            }
            catch
            {
                return false;
            }
        }

        private void comprobarExistenciaYCambiarColor() {
            ponerColorExiste(existeCarpetaEnTB());
            //try
            //{
            //    ponerColorExiste(new DirectoryInfo(TB_Direccion_Del_TXT.Text).Exists);
            //}
            //catch
            //{
            //    ponerColorExiste(false);
            //}


        }
        private void selecionarDiscoExistenteDe_direccionCarpeta() {
            if (TB_Direccion_Del_TXT.Text.Length>2) {
                string discoActual = Utiles.subs(TB_Direccion_Del_TXT.Text, 0, 3);
                for (int i = 0; i < CB_Discos_Conectados.Items.Count; i++)
                {
                    string disco_cb = CB_Discos_Conectados.Items[i].ToString();
                    if (disco_cb == discoActual)
                    {
                        //CB_Discos_Conectados.SelectedIndex = i;
                        mng_SI_discos.selectIndex(i);
                        break;
                    }
                }
            }
            
        }
        private void ponerColorExiste(bool existe) {
            TB_Direccion_Del_TXT.Foreground = existe ? Brushes.Green : Brushes.Red;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }


        private void btnMinimizeLogin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnCloseLogin_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void alApretarBotonCopiar(object sender, RoutedEventArgs e)
        {
            copiarTOKEN_alPortapapeles();
        }

        private void copiarTOKEN_alPortapapeles() {
            this.cwl(TB_Token.Text);
            this.copiarW(TB_Token.Text);
        }

        private void alApretar_B_BuscarArchivoDondeCrearToken(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog sfd = new Microsoft.Win32.SaveFileDialog();

            sfd.Filter = "TXT (*.txt)|*.*";

            bool? result = sfd.ShowDialog();

            if (result!=null&&result==true)//result.ToString() != string.Empty
            {
                

                //Console.WriteLine(sfd.FileName);
                FileInfo f = new FileInfo(Archivos.setExtencionStr(sfd.FileName, ".txt"));
                
                TB_Direccion_Del_TXT.Text = f.Directory != null ? f.Directory.ToString() : f.ToString();
                TB_Nombre_del_txt.Text = f.Name;

                comprobarExistenciaYCambiarColor();
                selecionarDiscoExistenteDe_direccionCarpeta();
            }
        }

        private FileInfo getDireccionCompletaTxt() {
            
            return new FileInfo(Archivos.setExtencionStr(new DirectoryInfo(TB_Direccion_Del_TXT.Text), TB_Nombre_del_txt.Text, ".txt"));
        }

        private bool existeDireccionCompletaTxt() {
            return TB_Nombre_del_txt.Text.Length > 0 ? getDireccionCompletaTxt().Exists: false;
        }

        private void alApretar_B_CrearTxtConToken(object sender, RoutedEventArgs e)
        {
            if (!existeCarpetaEnTB()) {
                System.Windows.MessageBox.Show("La carpeta tiene que existir");
                return;
            }
            //try
            //{
                if (!(TB_Nombre_del_txt.Text.Length>0)) {
                    System.Windows.MessageBox.Show("El nombre del txt no debe de estar vacío");
                    return;
                }

                if (existeDireccionCompletaTxt())
                {
                    System.Windows.MessageBox.Show("Este archivo ya existe");
                    return;
                }
                Archivos.crearTXT(new DirectoryInfo(TB_Direccion_Del_TXT.Text),TB_Nombre_del_txt.Text,TB_Token.Text);
                System.Windows.MessageBox.Show("TXT de token creado correctamente ");
            //}
            //catch {
            //    System.Windows.MessageBox.Show("La dirección total del archivo debe de ser correcta ");
            //}
        }

        private void alSeleccionar_CB_Discos(object sender, SelectionChangedEventArgs e)
        {
            if (seInicio&&CB_Discos_Conectados.SelectedIndex!=-1) {
                TB_Direccion_Del_TXT.Text = CB_Discos_Conectados.SelectedItem.ToString();
                comprobarExistenciaYCambiarColor();
            }
            
        }
    }
}
