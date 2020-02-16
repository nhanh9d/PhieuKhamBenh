﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Configuration;

namespace SieuAm.DataAccess
{
    public class Data
    {
        /// <summary>
        /// "System.Data.SqlClient"
        /// </summary>
        public static string dataProvider = ConfigurationManager.ConnectionStrings["ConnectionString"].ProviderName;
        private static readonly DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        #region parameters

        public static DbParameter CreateParameter(string ParameterName, DbType ParameterType, int ParameterSize)
        {
            DbParameter p = factory.CreateParameter();
            p.ParameterName = ParameterName;
            p.DbType = ParameterType;
            p.Size = ParameterSize;
            return p;
        }

        public static DbParameter CreateParameter(string ParameterName, object ParameterValue)
        {
            DbParameter p = factory.CreateParameter();
            p.ParameterName = ParameterName;

            p.Value = ParameterValue;


            return p;
        }

        public static DbParameter CreateParameter(string ParameterName)
        {
            DbParameter p = factory.CreateParameter();
            p.ParameterName = ParameterName;
            return p;
        }

        #endregion
    }
}
