using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Classes_Checar
{
    class Class_UO_Endereco
    {
        DAL_Sql dao = new DAL_Sql("localhost", "Checar", "root", "");

        public string LOGRADOURO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string CORDENADA_Y { get; set; }
        public string CORDENADA_X { get; set; }
        public int UO_ID { get; set; }


        public void Insert()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", LOGRADOURO, BAIRRO, CIDADE, UF, CEP, CORDENADA_Y, CORDENADA_X, UO_ID);
                dao.Inserir_novo_registro("UO_Endereco", sql);
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
                string sql = string.Format("Logradouro='{0}', Bairro='{1}', Cidade='{2}', UF='{3}', CEP='{4}', CordenadaY='{5}', CordenadaX='{6}'", LOGRADOURO, BAIRRO, CIDADE, UF, CEP, CORDENADA_Y, CORDENADA_X);
                string condicao = string.Format("Id='{0}'", UO_ID);
                dao.Alterar_registros("UO_Endereco", sql, condicao);
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
                string sql = string.Format("Id='{0}'", UO_ID);
                dao.Deletar_registro("UO_Endereco", sql);
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
                return dao.Select_registro("UO_Endereco");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
