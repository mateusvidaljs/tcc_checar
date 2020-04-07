using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Classes_Checar
{
    class Class_Principal_MarcaCarros
    {
        DAL_Sql dao = new DAL_Sql("localhost","Checar","root","");

        public int ID_MARCA_CARROS { get; set; }
        public string NOME_MARCA_CARROS { get; set; }
        public string NACIONAL { get; set; }

        public void Insert()
        {
            try
            {
                string sql = string.Format("'{0}','{1}','{2}'", ID_MARCA_CARROS, NOME_MARCA_CARROS, NACIONAL);
                dao.Inserir_novo_registro("Principal_MarcaCarros", sql);
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
                string sql = string.Format("Nome='{0}', Nacional='{1}'", NOME_MARCA_CARROS, NACIONAL);
                string condicao = string.Format("Id='{0}'", ID_MARCA_CARROS);
                dao.Alterar_registros("Principal_MarcaCarros", sql, condicao);
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
                string sql = string.Format("Id='{0}'", ID_MARCA_CARROS);
                dao.Deletar_registro("Principal_MarcaCarros", sql);
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
                return dao.Select_registro("Principal_MarcaCarros");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
