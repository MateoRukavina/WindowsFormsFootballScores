using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public FootbalLeagueRepository _footballLeagueRepository = new FootbalLeagueRepository(); 
        public BindingSource _tableBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            _tableBindingSource.DataSource = _footballLeagueRepository.GetFootballScores();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _tableBindingSource;

            DataGridViewImageColumn oCompetitionButton = new DataGridViewImageColumn();
            /*oCompetitionButton.Image = Image.FromFile("C:\\Users\\Downloads\\iconfinder_system-search_118797.png");*/
            oCompetitionButton.Width = 20;
            oCompetitionButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns.Insert(9, oCompetitionButton);
            dataGridView1.Columns[9].HeaderText = "ViewCompetition";

            dataGridView1.AutoGenerateColumns = false;
        }
    }
}
