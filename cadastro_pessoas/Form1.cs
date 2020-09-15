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

namespace cadastro_pessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cadastro_pessoas;Data Source=PC02\SQLEXPRESS";
        private string strSql = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_bairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into Table_cadastro(Nome,Telefone,Celular,Email,Endereco,Numero,Bairro,RG,CPF) values(@Nome,@Telefone,@Celular,@Email,@Endereco,@Numero,@Bairro,@RG,@CPF)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome",SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = masked_telefone.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = masked_celular.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txt_endereco.Text;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txt_numero.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txt_rg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO.");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            txt_nome.Clear();
            masked_telefone.Clear();
            masked_celular.Clear();
            txt_email.Clear();
            txt_endereco.Clear();
            txt_numero.Clear();
            txt_bairro.Clear();
            txt_rg.Clear();
            txt_cpf.Clear();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            strSql = "select*from Table_cadastro where Nome=@pesquisa";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txt_pesquisanome.Text;

            try
            {
                if (txt_pesquisanome.Text == string.Empty)
                {
                    MessageBox.Show("VOCE NAO DIGITOU UM NOME.");
                }

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows== false)
                {
                    throw new Exception("ESTE NOME NAO ESTA CADASTRADO.");
                }

                dr.Read();

                txt_nome.Text = Convert.ToString(dr["Nome"]);
                masked_telefone.Text = Convert.ToString(dr["Telefone"]);
                masked_celular.Text = Convert.ToString(dr["Celular"]);
                txt_email.Text = Convert.ToString(dr["Email"]);
                txt_endereco.Text = Convert.ToString(dr["Endereco"]);
                txt_numero.Text = Convert.ToString(dr["Numero"]);
                txt_bairro.Text = Convert.ToString(dr["Bairro"]);
                txt_rg.Text = Convert.ToString(dr["RG"]);
                txt_cpf.Text = Convert.ToString(dr["CPF"]);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            txt_pesquisanome.Clear();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            strSql = "update Table_cadastro set Nome=@Nome, Telefone=@Telefone, Celular=@Celular, Email=@Email, Endereco=@Endereco, Bairro=@Bairro, RG=@RG, CPF=@CPF, Numero=@Numero where Nome=@Nome";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = masked_telefone.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = masked_celular.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txt_endereco.Text;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txt_numero.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txt_rg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO ALTERADO COM SUCESSO!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            txt_nome.Clear();
            masked_telefone.Clear();
            masked_celular.Clear();
            txt_email.Clear();
            txt_endereco.Clear();
            txt_numero.Clear();
            txt_bairro.Clear();
            txt_rg.Clear();
            txt_cpf.Clear();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            strSql = "delete from Table_cadastro where Nome=@Nome";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("EXCLUSAO DE CADASTRO REALIZADA COM SUCESSO!");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            txt_nome.Clear();
            masked_telefone.Clear();
            masked_celular.Clear();
            txt_email.Clear();
            txt_endereco.Clear();
            txt_numero.Clear();
            txt_bairro.Clear();
            txt_rg.Clear();
            txt_cpf.Clear();
        }
    }
}
