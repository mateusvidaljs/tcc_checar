using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Classes_Checar
{
    class Class_UO_TipoDeServico
    {
        DAL_Sql dao = new DAL_Sql("localhost","Checar","root","");

        public int ID_TIPOSERVICO { get; set; }
        public string TIPO { get; set; }
        public string DESCRICAO { get; set; }
        public float PRECO { get; set; }

        public void Insert()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}','{3}'", ID_TIPOSERVICO, TIPO, DESCRICAO, PRECO.ToString().Replace(',', '.'));
                dao.Inserir_novo_registro("UO_TipoDeServico", sql);
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
                string sql = string.Format("Tipo='{0}', Descricao='{1}', Preco='{2}'", TIPO, DESCRICAO, PRECO.ToString().Replace(',', '.'));
                string condicao = string.Format("Id='{0}'", ID_TIPOSERVICO);
                dao.Alterar_registros("UO_TipoDeServico", sql, condicao);
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
                string sql = string.Format("Id='{0}'", ID_TIPOSERVICO);
                dao.Deletar_registro("UO_TipoDeServico", sql);
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
                return dao.Select_registro("UO_TipoDeServico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
