using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Regenerate_Indexes
{
    public partial class Form1 : Form
    {

        private string serverName;
        private string databaseName;
        private string procedureName;
        Form2 form2 = new Form2();
        ConnectionDB connection;

        public Form1()
        {
            InitializeComponent();
            form2.ConnectionDataReceived += Form2_ConnectionDataReceived;
            form2.ShowDialog();
        }

        private void Form2_ConnectionDataReceived(string serverName, string databaseName, string procedureName)
        {

            connection=new ConnectionDB(serverName,databaseName, procedureName);
            form2.ConnectionDataReceived -= Form2_ConnectionDataReceived;
        }

        private void buttonRegenerateIndexes_Click(object sender, EventArgs e)
        {
                if (connection.executeProcedure())
                {
                    MessageBox.Show("Índices regenerados con éxito");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error inesperado");
                }
            
        }
    }
}
