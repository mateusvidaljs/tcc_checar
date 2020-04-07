using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Classes
{
    class Class_CLI_ClienteDicas
    {
        DAL_Sql dao = new DAL_Sql("localhost", "Checar", "root", "");

        public int ID_CLIENTE_DICAS { get; set; }
        public string TITULO { get; set; }
        public string DESCRICAO { get; set; }
        public DateTime DATA { get; set; }

        //Estrutura do CRUD
        public void Insert()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}','{3}'", ID_CLIENTE_DICAS, TITULO, DESCRICAO, DATA.ToString("yyyy/MM/dd"));
                dao.Inserir_novo_registro("Cliente_Dicas", sql);
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
                string sql = string.Format("Titulo='{0}', Descricao='{1}', Date='{2}'", TITULO, DESCRICAO, DATA.ToString("yyyy/MM/dd"));
                string condicao = string.Format("Id='{0}'", ID_CLIENTE_DICAS);
                dao.Alterar_registros("Cliente_Dicas", sql, condicao);
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
                string sql = string.Format("Id='{0}'", ID_CLIENTE_DICAS);
                dao.Deletar_registro("Cliente_Dicas", sql);
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
                return dao.Select_registro("Cliente_Dicas");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
