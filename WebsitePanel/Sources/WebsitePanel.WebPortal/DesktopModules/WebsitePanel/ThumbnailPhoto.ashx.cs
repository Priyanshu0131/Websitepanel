﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebsitePanel.EnterpriseServer;
using WebsitePanel.EnterpriseServer.Base.HostedSolution;
using WebsitePanel.Providers.HostedSolution;
using WebsitePanel.Providers.Common;
using WebsitePanel.Providers.ResultObjects;

namespace WebsitePanel.Portal
{
    /// <summary>
    /// Summary description for ThumbnailPhoto
    /// </summary>
    public class ThumbnailPhoto : IHttpHandler
    {
        public HttpContext Context = null;

        public int Param(string key)
        {
            string val = Context.Request.QueryString[key];
            if (val == null)
            {
                val = Context.Request.Form[key];
                if (val == null) return 0;
            }

            int res = 0;
            int.TryParse(val, out res);

            return res;
        }



        public void ProcessRequest(HttpContext context)
        {
            Context = context;

            int ItemID = Param("ItemID");
            int AccountID = Param("AccountID");

            BytesResult res = ES.Services.ExchangeServer.GetPicture(ItemID, AccountID);
            if (res.IsSuccess)
            {
                context.Response.ContentType = "image/jpeg";
                context.Response.BinaryWrite(res.Value);
            }
            else
            {
                context.Response.Redirect(PortalUtils.GetThemedImage("empty.gif"), true);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}