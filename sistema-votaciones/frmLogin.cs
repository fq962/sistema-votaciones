using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using System.Windows.Forms;
using SweetAlertSharp;
using System.Runtime.InteropServices;

namespace sistema_votaciones
{
    public partial class frmLogin : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        public frmLogin()
        {
            InitializeComponent();
            lbUsuario.Width = 100;
            lbUsuario.Height = 150;
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            SweetAlert.Show("WOHOOO", "Hola gato, te amo");
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            /* Mover o arrastrar el formulario con el mouse */
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            /* Cierra Formulario Login */
            this.Close();
        }
    }
}
