using ejemplo.EApplication;
using ejemplo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo.UI
{
    public partial class FrmLogin : Form
    {
        //IEApplication<Footballteam> _eApplication;
        //IEApplication<Sale> _sale;
        LoginAAplication _login;
        public FrmLogin()
        {
            InitializeComponent();
            _login = new LoginAAplication();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            try
            {
            
                _login.Login(this.TxtUser.Text, this.TxtPassWord.Text);
                FrmMain frmMain = (FrmMain)this.MdiParent;
                frmMain.ValidarFormulario();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
