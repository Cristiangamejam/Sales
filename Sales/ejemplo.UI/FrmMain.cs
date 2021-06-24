using ejemplo.EApplication;
using ejemplo.Entities;
using ejemplo.Services;
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
    public partial class FrmMain : Form
    {
        //IEApplication<Footballteam> _footbal = new  ;

        //IEApplication<Footballteam> _eApplication;

        //_footbal = IEApplication<Footballteam>;
        //    _eApplication = EApplication<Footballteam>;

        private UserApplication _user;
        private LoginAAplication _login;

        //private Guid _session;
        //        public Guid Session 
        //        { 
        //            get 
        //            { 
        //                return _session;
        //            }
        //            set
        //            {
        //                _session = value;
        //                ShowUser();
        //                ValidateForm();
        //;            } 
        //        }

        //private void ValidateForm()
        //{
        //    MnuLogin.Enabled = (_session == Guid.Empty);
        //    MnuLogout.Enabled = (_session != Guid.Empty);

        //}

        public FrmMain()
        {
            InitializeComponent();
            ValidarFormulario();
            _user = new UserApplication();
            _login = new LoginAAplication();
        }

        public void ValidarFormulario()
        {
            if(SessionManager.IsLogeed())
            {
                LblSession.Text = "Inicie Sessión";
            }
            else
            {
                LblSession.Text = SessionManager.Session.Name;
            }

            MnuLogin.Enabled = SessionManager.IsLogeed();
            MnuLogout.Enabled = !SessionManager.IsLogeed();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
        }

        private void MnuLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.MdiParent = this;
            frmLogin.Show();
        }

        private void MnuLogout_Click(object sender, EventArgs e)
        {
            _login.LogOut();
            ValidarFormulario();
        }
    }
}
