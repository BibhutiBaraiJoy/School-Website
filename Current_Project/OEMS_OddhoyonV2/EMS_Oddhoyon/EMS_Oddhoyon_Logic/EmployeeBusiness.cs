using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS_Oddhoyon_Business;
using EMS_Oddhoyon_Service;

namespace EMS_Oddhoyon_Logic
{
   public class EmployeeBusiness
    {
       EmployeeService aEmployeeService = new EmployeeService();

       public List<Qry_EmployeeBasicInfo> GetAllEmployees(int selectN)
       {
           try
           {
               return aEmployeeService.GetAllEmployees(selectN);

           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }
}
