using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regenerate_Indexes
{
    public partial class Form1 : Form
    {

        ConnectionDB connection;

        public Form1()
        {
            InitializeComponent();
            initializeServer();
        }

        void initializeServer()
        {
            string server = ".";
            string database = "Club_Nautico";

            connection = new ConnectionDB(server, database);
        }

        private void buttonRegenerateIndexes_Click(object sender, EventArgs e)
        {
            if (connection.executeProcedure(
                "regenerate_indexes"))
            {
                MessageBox.Show("Los índices se regeneraron con exito");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al regenerar los indices");
            }
        }
    }
}
