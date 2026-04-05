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
    public partial class Form1 : Form
    {

        private SqlConnection conexao;
        private SqlCommand comando;
        private string strsql, strconex;

        public Form1()
        {
            InitializeComponent();
        }

        private void btgravar_Click(object sender, EventArgs e)
        {
            try

            {
                strconex = "data source= .\\SQLEXPRESS ; initial catalog = RHSolucoes; " + " integrated security = sspi";

                conexao = new SqlConnection(strconex);
                conexao.Open();

                strsql = "INSERT INTO SETORES (setor, descricao) " + " values ('" + txtsetor.Text + "', '" + txtdescricao.Text + "')";

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
