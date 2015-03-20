//Coded by Anisuzzaman 
//Date 11/3/2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS_Oddhoyon_Business;
namespace EMS_Oddhoyon_Service
{
   public class EventService : IDisposable
   {

       #region Initial
       private oemsbdv2_bmsc_dbEntities context = new oemsbdv2_bmsc_dbEntities();

         ~EventService()
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


         public int UpdateEvents(Tbl_Events objEvents)
         {
             try
             {

                 context.Tbl_Events.ApplyChanges(objEvents);
                 return context.SaveChanges();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public int InsertEvents(Tbl_Events objEvents)
         {
             try
             {
                 context.Tbl_Events.AddObject(objEvents);
                 return context.SaveChanges();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public int DeleteEvents(Tbl_Events objEvents)
         {
             try
             {
                 context.Tbl_Events.DeleteObject(objEvents);
                 return context.SaveChanges();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public List<Tbl_Events> GetAllEvents(int selectN)
         {
             try
             {
                return context.Tbl_Events.Take(selectN).ToList();
                 
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

        #endregion


    }
}
