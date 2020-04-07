using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Classes
{
    class Class_CLI_ClienteUsuario
    {
        DAL_Sql dao = new DAL_Sql("localhost", "Checar", "root", "");

        public int ID_CLIENTE_USUARIO { get; set; }
        public string NOME { get; set; }
        public string EMAIL { get; set; }
        public string TELEFONE { get; set; }
        public int ID_LOGIN { get; set; }

        public void Insert()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}','{3}','{4}'", ID_CLIENTE_USUARIO, NOME, EMAIL, TELEFONE, ID_LOGIN);
                dao.Inserir_novo_registro("Cliente_Usuario", sql);
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
                string sql = string.Format("Nome='{0}', Email='{1}', Telefone='{2}', LoginId='{3}'", NOME, EMAIL, TELEFONE, ID_LOGIN);
                string condicao = string.Format("Id='{0}'", ID_CLIENTE_USUARIO);
                dao.Alterar_registros("Cliente_Usuario", sql, condicao);
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
                string sql = string.Format("Id='{0}'", ID_CLIENTE_USUARIO);
                dao.Deletar_registro("Cliente_Usuario", sql);
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
                return dao.Select_registro("Cliente_Usuario");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
