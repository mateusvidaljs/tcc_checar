using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Classes
{
    class Class_CLI_PrincipalLogin
    {
        DAL_Sql dao = new DAL_Sql("localhost", "Checar", "root", "");

        public int ID_PRINCIPAL_LOGIN { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }
        public string TIPO_USUARIO { get; set; }
        public int ATIVO { get; set; }

        //Estrutura do CRUD
        public void Insert()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}','{3}','{4}'", ID_PRINCIPAL_LOGIN, LOGIN, SENHA, TIPO_USUARIO, ATIVO);
                dao.Inserir_novo_registro("Principal_Login", sql);
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
                string sql = string.Format("Login='{0}', Senha='{1}', TipoUsuario='{2}', Ativo='{3}'", LOGIN, SENHA, TIPO_USUARIO, ATIVO);
                string condicao = string.Format("Id='{0}'", ID_PRINCIPAL_LOGIN);
                dao.Alterar_registros("Principal_Login", sql, condicao);
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
                string sql = string.Format("Id='{0}'", ID_PRINCIPAL_LOGIN);
                dao.Deletar_registro("Principal_Login", sql);
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
                return dao.Select_registro("Principal_Login");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
