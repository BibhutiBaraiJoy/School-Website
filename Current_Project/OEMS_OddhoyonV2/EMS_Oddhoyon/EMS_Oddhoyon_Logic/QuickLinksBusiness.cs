using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMS_Oddhoyon_Business;
using EMS_Oddhoyon_Service;

namespace EMS_Oddhoyon_Logic
{
   public class QuickLinksBusiness
    {
         QuickLinkService aQuickLinkService = new QuickLinkService();

         ~QuickLinksBusiness()
        {
            aQuickLinkService.Dispose();
            aQuickLinkService = null;
            aQuickLinkService = null;
            aQuickLinkService = null;
        }
         public bool InsertQuickLink(Tbl_QuickLinks objQuickLink)
        {
            try
            {
                if (aQuickLinkService.InsertQuickLink(objQuickLink) > 0)
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

         public bool UpdateQuickLink(Tbl_QuickLinks objQuickLink)
        {
            try
            {


                if (aQuickLinkService.UpdateQuickLink(objQuickLink) > 0)
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
         public bool DeleteQuickLink(Tbl_QuickLinks objQuickLink)
        {
            try
            {


                if (aQuickLinkService.DeleteQuickLink(objQuickLink) > 0)
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

         public List<Tbl_QuickLinks> GetAllQuickLink(int selectN)
        {
            return aQuickLinkService.GetAllQuickLink(selectN);

        }
    }
}
