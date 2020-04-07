using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Classes_Checar
{
    public class Class_UO_UnidadeOrganizacional
    {
        /// <summary>
        /// Classe referente a tabela da unidade organizacional (UO_UnidadeOrganizacional)
        /// .MBV
        /// </summary>

        DAL_Sql dao = new DAL_Sql("localhost", "Checar", "root", "");

        public int ID_UO { get; set; }
        public DateTime HORARIO_FUNCIONAMENTOI { get; set; }
        public string NOME_JURIDICO { get; set; }
        public string STATUS_FUNCIONAMENTO { get; set; }
        public string NOME_FANTASIA { get; set; }
        public string CNPJ { get; set; }
        public string EMAIL { get; set; }
        public DateTime HORARIO_FUNCIONAMENTOF { get; set; }

        //Estrutura do CRUD
        public void Insert()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", ID_UO, HORARIO_FUNCIONAMENTOI.ToString("yyyy/MM/dd"), NOME_JURIDICO, STATUS_FUNCIONAMENTO, NOME_FANTASIA, CNPJ, HORARIO_FUNCIONAMENTOF.ToString("yyyy/MM/dd"), EMAIL);
                dao.Inserir_novo_registro("UO_UnidadeOrganizacional", sql);
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
                string sql = string.Format("HorarioFuncionamentoi='{0}', NomeJuridico='{1}', Status_Funcionamento='{2}', NomeFantasia='{3}', CNPJ='{4}', HorarioFuncionamentof='{6}', Email='{5}'", HORARIO_FUNCIONAMENTOI.ToString("yyyy/MM/dd"), NOME_JURIDICO, STATUS_FUNCIONAMENTO, NOME_FANTASIA, CNPJ, HORARIO_FUNCIONAMENTOF.ToString("yyyy/MM/dd"), EMAIL);
                string condicao = string.Format("Id='{0}'", ID_UO);
                dao.Alterar_registros("UO_UnidadeOrganizacional", sql, condicao);
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
                string sql = string.Format("Id='{0}'", ID_UO);
                dao.Deletar_registro("UO_UnidadeOrganizacional", sql);
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
                return dao.Select_registro("UO_UnidadeOrganizacional");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
