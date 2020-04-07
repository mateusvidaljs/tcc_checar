using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Classes
{
    class Class_CLI_ClientePreferencia
    {
        DAL_Sql dao = new DAL_Sql("localhost", "Checar", "root", "");

        public int ID_CLIENTE_PREFERENCIA { get; set; }
        public int NOTIFICACAO_DICA_ATIVA { get; set; }
        public int ID_CLIENTE { get; set; }

        public void Insert()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}'",ID_CLIENTE_PREFERENCIA, NOTIFICACAO_DICA_ATIVA, ID_CLIENTE);
                dao.Inserir_novo_registro("Cliente_Preferencia", sql);
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
                string sql = string.Format("NotificacaoDicaAtiva='{0}', ClienteId='{1}'", NOTIFICACAO_DICA_ATIVA, ID_CLIENTE);
                string condicao = string.Format("Id='{0}'", ID_CLIENTE_PREFERENCIA);
                dao.Alterar_registros("Cliente_Preferencia", sql, condicao);
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
                string sql = string.Format("Id='{0}'", ID_CLIENTE_PREFERENCIA);
                dao.Deletar_registro("Cliente_Preferencia", sql);
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
                return dao.Select_registro("Cliente_Preferencia");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
