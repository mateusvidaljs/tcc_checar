using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Classes
{
    class Class_CLI_ClienteDadosManutencao
    {
        DAL_Sql dao = new DAL_Sql("localhost", "Checar", "root", "");

        public int ID_CLIENTE_DADOS_MANUTENCAO { get; set; }
        public string TIPO { get; set; }
        public string PRIORIDADE { get; set; }
        public string DESCRICAO { get; set; }
        public float CUSTO_MEDIO { get; set; }
        public int ID_CLIENTE { get; set; }

        //Estrutura do CRUD
        public void Insert()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}'", ID_CLIENTE_DADOS_MANUTENCAO, TIPO, PRIORIDADE, DESCRICAO, CUSTO_MEDIO, ID_CLIENTE);
                dao.Inserir_novo_registro("Cliente_DadosManutencao", sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update()
        {
            try
            {
                string sql = string.Format("Tipo='{0}', Prioridade='{1}', Descricao='{2}', CustoMedio='{3}', ClienteId='{4}'", TIPO, PRIORIDADE, DESCRICAO, CUSTO_MEDIO, ID_CLIENTE);
                string condicao = string.Format("Id='{0}'", ID_CLIENTE_DADOS_MANUTENCAO);
                dao.Alterar_registros("Cliente_DadosManutencao", sql, condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete()
        {
            try
            {
                string sql = string.Format("Id='{0}'", ID_CLIENTE_DADOS_MANUTENCAO);
                dao.Deletar_registro("Cliente_DadosManutencao", sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Select()
        {
            try
            {
                return dao.Select_registro("Cliente_DadosManutencao");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
