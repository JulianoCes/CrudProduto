using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CrudProduto
{

    public partial class CrudProduto : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=aula2020.database.windows.net;Initial Catalog=Juliano;User ID=tds02;Password=@nuvem2020;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
       
        public CrudProduto()
        {
            InitializeComponent();
        }

        public void CarregaDgvProduto()
        {
            String query = "SELECT * FROM Produto";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable produto = new DataTable();
            da.Fill(produto);
            MetDgvProduto.DataSource = produto;
            con.Close();
        }

        private void MetbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MetbtnCadastra_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "InserirProduto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", MetxtNome.Text);
                cmd.Parameters.AddWithValue("@tipo", MetxtTipo.Text);
                cmd.Parameters.AddWithValue("@marca", MetxtMarca.Text);
                cmd.Parameters.AddWithValue("@quantidade", MetxtQuantidade.Text);
                cmd.Parameters.Add("@valor", SqlDbType.Decimal, 3).Value = MetxtValor.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Produto inserido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MetxtId.Text = "";
                MetxtNome.Text = "";
                MetxtTipo.Text = "";
                MetxtMarca.Text = "";
                MetxtQuantidade.Text = "";
                MetxtValor.Text = "";
                CarregaDgvProduto();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void MetbtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "AtualizarProduto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.MetxtId.Text);
                cmd.Parameters.AddWithValue("@nome", this.MetxtNome.Text);
                cmd.Parameters.AddWithValue("@tipo", this.MetxtTipo.Text);
                cmd.Parameters.AddWithValue("@marca", this.MetxtMarca.Text);
                cmd.Parameters.AddWithValue("@quantidade", this.MetxtQuantidade.Text);
                cmd.Parameters.Add("@valor", SqlDbType.Decimal, 3).Value = MetxtValor.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Produto atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MetxtId.Text = "";
                MetxtNome.Text = "";
                MetxtTipo.Text = "";
                MetxtMarca.Text = "";
                MetxtQuantidade.Text = "";
                MetxtValor.Text = "";
                CarregaDgvProduto();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void MetbtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "ExcluirProduto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.MetxtId.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Produto apagado com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MetxtId.Text = "";
                MetxtNome.Text = "";
                MetxtTipo.Text = "";
                MetxtMarca.Text = "";
                MetxtQuantidade.Text = "";
                MetxtValor.Text = "";
                CarregaDgvProduto();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void MetbtnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "LocalizarProduto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.MetxtId.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    MetxtId.Text = rd["Id"].ToString();
                    MetxtNome.Text = rd["nome"].ToString();
                    MetxtTipo.Text = rd["tipo"].ToString();
                    MetxtMarca.Text = rd["marca"].ToString();
                    MetxtQuantidade.Text = rd["quantidade"].ToString();
                    MetxtValor.Text = rd["valor"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Sem registro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                }
                CarregaDgvProduto();

            }
            finally
            {
            }
        }

        private void CrudProduto_Load(object sender, EventArgs e)
        {
            CarregaDgvProduto();
        }

        private void MetDgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.MetDgvProduto.Rows[e.RowIndex];
                MetxtId.Text = row.Cells[0].Value.ToString();
                MetxtNome.Text = row.Cells[1].Value.ToString();
                MetxtTipo.Text = row.Cells[2].Value.ToString();
                MetxtMarca.Text = row.Cells[3].Value.ToString();
                MetxtQuantidade.Text = row.Cells[4].Value.ToString();
                MetxtValor.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
    

