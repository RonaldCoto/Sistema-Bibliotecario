﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Sistema_Bibliotecario_INJI
{
    public class Conexion
    {
        
            private SqlConnection conexion = new SqlConnection("Server=(local);DataBase=BDINJI;Integrated Security=true");

            public SqlConnection AbrirConexion()
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                return conexion;

            }

            public SqlConnection CerrarConexion()
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                return conexion;
            }
       

           
        }


    }

   

