using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SieuAm.DataAccess;
namespace SieuAm.Business
{
    public class TemplateTblBLL
    {
        public void Add(TemplateTblInfo template)
        {
            string sql = "INSERT INTO [dbo].[templateTbl]"
                       + "([templateName]"
                       + ",[resultDetail]"
                       + ",[diagnosis]"
                       + ",[analysis])"
                       + " VALUES "
                       + "(N'" + template.TemplateName + "'"
                       + ",N'" + template.ResultDetail + "'"
                       + ",N'" + template.Diagnosis + "'"
                       + ",N'" + template.Analysis + "'" + ")";
            SqlExtend.ExecuteNonQuery(Data.ConnectionString, CommandType.Text, sql);
        }
        public void Update(TemplateTblInfo template)
        {
            if (template.TemplateID > 0)
            {
                string sql = "UPDATE [dbo].[templateTbl]"
                           + " SET[templateName] = N'" + template.TemplateName + "'"
                           + ",[resultDetail] = N'" + template.ResultDetail + "'"
                           + ",[diagnosis] = N'" + template.Diagnosis + "'"
                           + ",[analysis] = N'" + template.Analysis + "'"
                           + " WHERE templateID = " + template.TemplateID;
                SqlExtend.ExecuteNonQuery(Data.ConnectionString, CommandType.Text, sql);
            }
        }
        public DataTable GetTemplates(TemplateTblInfo template)
        {
            string sql = "SELECT [templateID]"
                       + ",[templateName]"
                       + ",[resultDetail]"
                       + ",[diagnosis]"
                       + ",[analysis]"
                       + " FROM [dbo].[templateTbl]"
                       + " WHERE 1=1";
            if (template.TemplateID > 0)
            {
                sql += " AND templateID = " + template.TemplateID;
            }
            sql += " ORDER BY templateID ASC";
            return SqlExtend.ExecuteDataTable(Data.ConnectionString, CommandType.Text, sql);
        }
        // Delete
        public void Delete(TemplateTblInfo template)
        {
            if (template.TemplateID > 0)
            {
                string sql = "DELETE FROM [dbo].[templateTbl]"
                           + " WHERE templateID = " + template.TemplateID;
                SqlExtend.ExecuteNonQuery(Data.ConnectionString, CommandType.Text, sql);
            }
        }
    }
}
