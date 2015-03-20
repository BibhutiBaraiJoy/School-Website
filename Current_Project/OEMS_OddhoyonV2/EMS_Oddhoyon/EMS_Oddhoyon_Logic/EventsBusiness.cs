using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS_Oddhoyon_Business;
using EMS_Oddhoyon_Service;

namespace EMS_Oddhoyon_Logic
{
   public class EventsBusiness
    {
       EventService aEventService = new EventService();

       ~EventsBusiness()
        {
            aEventService.Dispose();
            aEventService = null;
            aEventService = null;
            aEventService = null;
        }


       public bool InsertEvents(Tbl_Events objEvents)
       {
           try
           {
               if (aEventService.InsertEvents(objEvents) > 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       public bool UpdateEvents(Tbl_Events objEvents)
       {
           try
           {
               
        
               if (aEventService.UpdateEvents(objEvents) > 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public bool DeleteEvents(Tbl_Events objEvents)
       {
           try
           {


               if (aEventService.DeleteEvents(objEvents) > 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       public List<Tbl_Events> GetAllEvents(int selectN)
       {
           return aEventService.GetAllEvents(selectN);
       
       }

      
       
    }
}
