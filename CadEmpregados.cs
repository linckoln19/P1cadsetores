using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadSetores
{
    public partial class CadEmpregados : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblempregados;
        private SqlCommand comando;
        private string strsql, strconex;

        public CadEmpregados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CadEmpregados_Load(object sender, EventArgs e)
        {
            strconex = "data source= .\\SQLEXPRESS ; initial catalog= RHSolucoes; " + " integrated security= sspi";

            conexao = new SqlConnection(strconex);
            conexao.Open();
            tblempregados = new DataTable();
            strsql = "SELECT * FROM Empregados ";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblempregados);

            cbocodsetor.DataSource = tblempregados;
            cbocodsetor.DisplayMember = "setor";
            cbocodsetor.ValueMember = "codsetor";
            lblcodsetor.Text = cbocodsetor.SelectedValue.ToString();
        }

        private void cbocodsetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocodsetor.ValueMember = "codsetor";
            lblcodsetor.Text = cbocodsetor.SelectedValue.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                strconex = "data source= .\\SQLEXPRESS ; initial catalog = RHSolucoes; " + " integrated security = sspi";

                conexao = new SqlConnection(strconex);
                conexao.Open();

                strsql = "INSERT INTO EMPREGADOS (empregado, bairro, cidade) "
                    + " values ('" + txtempregado.Text + "', '" + txtbairro.Text + "', '" + txtcidade.Text + "')";

                comando = new SqlCommand(strsql, conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso!", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception er)
            {

                MessageBox.Show("Erro ao gravar," + er.Message, "mensagem",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
