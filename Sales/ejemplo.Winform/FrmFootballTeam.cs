
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

namespace ejemplo.Winform
{
    public partial class FrmFootballTeam : Form
    {
           //IApplication<Footballteam> _footbal;IApplication<Footballteam> footbal

        public FrmFootballTeam()
        {
            InitializeComponent();
            //_footbal = footbal;
        }

     

        public void GetFootbal()
        {

            //DgvFootball.DataSource = _footbal.GetAll();
            //return Ok( new Footballteam() { 
            //    Name = "Unión",
            //    Score = 100,
            //});
        }

        private void FrmFootballTeam_Load(object sender, EventArgs e)
        {

        }
    }
}
