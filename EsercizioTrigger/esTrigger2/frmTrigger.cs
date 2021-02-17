using System;
using System.Windows.Forms;

namespace esTrigger2
{
    public partial class frmTrigger : Form
    {
        public frmTrigger()
        {
            InitializeComponent();
        }

        private void frmTrigger_Load(object sender, EventArgs e)
        {
            clienteTableAdapter.Fill(dbTrigger2DataSet.Cliente);
            updateAll();
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            clienteTableAdapter.Update(dbTrigger2DataSet.Cliente);
            updateAll();
        }

        private void updateAll()
        {
            storicoUpdateTableAdapter.Fill(dbTrigger2DataSet.StoricoUpdate);
            storicoCancellazioniTableAdapter.Fill(dbTrigger2DataSet.StoricoCancellazioni);
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.Update();
            dataGridView2.Refresh();
            dataGridView3.Update();
            dataGridView3.Refresh();
        }

        private void tabControlTrigger_Selecting(object sender, TabControlCancelEventArgs e)
        {
            updateAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
