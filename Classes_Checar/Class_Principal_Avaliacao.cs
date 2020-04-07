using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Classes_Checar
{
    class Class_Principal_Avaliacao
    {
        DAL_Sql dao = new DAL_Sql("localhost", "Checar", "root", "");

        public int ID_PRINCIPAL_AVALIACAO { get; set; }
        public float VALOR_AVALIACAO { get; set; }
        public float SOMA_AVALIACAO { get; set; }
        public int NUMERO_AVALIACAO { get; set; }
        public int UO_UNIDADE_ORGANIZACIONAL_ID { get; set; }

        public void Insert()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}','{3}','{4}'", ID_PRINCIPAL_AVALIACAO, VALOR_AVALIACAO.ToString().Replace(',', '.'), SOMA_AVALIACAO.ToString().Replace(',', '.'), NUMERO_AVALIACAO, UO_UNIDADE_ORGANIZACIONAL_ID);
                dao.Inserir_novo_registro("Principal_Avaliacao", sql);
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
                string sql = string.Format("ValorAvaliacao='{0}', SomaAvaliacao='{1}', NumeroAvaliacao='{2}', UnidadeOrganizacionalId='{3}' ", VALOR_AVALIACAO.ToString().Replace(',', '.'), SOMA_AVALIACAO.ToString().Replace(',', '.'), NUMERO_AVALIACAO, UO_UNIDADE_ORGANIZACIONAL_ID);
                string condicao = string.Format("Id='{0}'", ID_PRINCIPAL_AVALIACAO);
                dao.Alterar_registros("Principal_Avaliacao", sql, condicao);
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
                string sql = string.Format("Id='{0}'", ID_PRINCIPAL_AVALIACAO);
                dao.Deletar_registro("Principal_Avaliacao", sql);
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
                return dao.Select_registro("Principal_Avaliacao");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
