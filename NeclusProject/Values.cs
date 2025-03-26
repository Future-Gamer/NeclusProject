﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NucleusProject
{
    public class Values
    {
        private static readonly string baseDir = @"C:\Users\jeffb\Source\Repos\NeclusProject\NeclusProject";

        public static string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
                builder.AttachDBFilename = baseDir + @"App_Data\NucleusDatabase.mdf";
                builder.IntegratedSecurity = true;

                return builder.ToString();
            }
        }

    }
}