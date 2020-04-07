using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Classes_Checar
{
    class Class_UO_OrdemDeServico
    {
        DAL_Sql dao = new DAL_Sql("localhost", "Checar", "root", "");

        public int ID_ORDEM_SERVICO { get; set; }
        public string STATUS { get; set; }
        public DateTime DATA_RETIRADA { get; set; }
        public DateTime DATA_ENTREGA { get; set; }
        public int UO_ID { get; set; }
        public int CLIENTE_ID { get; set; }
        public int TIPO_SERVICO_ID { get; set; }

        //Estrutura do CRUD
        public void Insert()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}'", ID_ORDEM_SERVICO, STATUS, DATA_RETIRADA.ToString("yyyy/MM/dd"), DATA_ENTREGA.ToString("yyyy/MM/dd"), UO_ID, CLIENTE_ID, TIPO_SERVICO_ID);
                dao.Inserir_novo_registro("UO_OrdemDeServico", sql);
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
                string sql = string.Format("Status='{0}', DataRetirada='{1}', DataEntrega='{2}', UnidadeOrganizacionalId='{3}', ClienteId='{4}', TipoServicoId='{5}' ", STATUS, DATA_RETIRADA.ToString("yyyy/MM/dd"), DATA_ENTREGA.ToString("yyyy/MM/dd"), UO_ID, CLIENTE_ID, TIPO_SERVICO_ID);
                string condicao = string.Format("Id='{0}'", ID_ORDEM_SERVICO);
                dao.Alterar_registros("UO_OrdemDeServico", sql, condicao);
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
                string sql = string.Format("Id='{0}'", ID_ORDEM_SERVICO);
                dao.Deletar_registro("UO_OrdemDeServico", sql);
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
                return dao.Select_registro("UO_OrdemDeServico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
