﻿using CRUD.DataLayer;
using CRUD.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BusinessLayer
{
    public class DepartamentoBL
    {
        DepartamentoDL departamentoDL = new DepartamentoDL();

        public List<Departamento> Lista()
        {
            try
            {

                return departamentoDL.Lista();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
