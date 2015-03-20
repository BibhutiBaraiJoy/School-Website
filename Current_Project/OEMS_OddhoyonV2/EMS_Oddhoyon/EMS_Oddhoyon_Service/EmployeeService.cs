using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS_Oddhoyon_Business;

namespace EMS_Oddhoyon_Service
{
    public class EmployeeService : IDisposable
    {
           #region Initial
       private oemsbdv2_bmsc_dbEntities context = new oemsbdv2_bmsc_dbEntities();

       ~EmployeeService()
        {
            if (context != null){try{context.Dispose();context = null;}catch { }}
        }
         private bool disposedValue = false;

         protected virtual void Dispose(bool disposing)
         {
             if (!this.disposedValue)
             {
                 if (disposing)
                 {
                     if (context != null) { try { context.Dispose(); context = null; } catch { } }
                 }
             }
             this.disposedValue = true;
         }

         public void Dispose()
         {
             Dispose(true);
             GC.SuppressFinalize(this);
         }

       #endregion 

         #region CRUD


         public List<Qry_EmployeeBasicInfo> GetAllEmployees(int selectN)
         {
             try
             {
                 return context.Qry_EmployeeBasicInfo.Take(selectN).ToList();

             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         #endregion
    }
}
