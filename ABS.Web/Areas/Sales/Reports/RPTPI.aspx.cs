﻿using ABS.Models;
using ABS.Models.ViewModel.Sales;
using ABS.Models.ViewModel.SystemCommon;
using ABS.Reports.Sales;
using ABS.Service.Sales.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABS.Web.Areas.Sales.Reports
{
    public partial class RPTPI : System.Web.UI.Page
    {
        PIMgt objPIMgt = new PIMgt();

        protected void Page_Load(object sender, EventArgs e)
        {
            int lUserID = Convert.ToInt16(Session["UserID"]);
            int lCompanyID = Convert.ToInt16(Session["CompanyID"]);

            if (!IsPostBack)
            {
                if (!IsPostBack && lUserID > 0 && lCompanyID > 0)
                {
                    LoadCompany(lUserID, lCompanyID);
                    // LoadPI(lUserID, lCompanyID);
                    ListItem item = new ListItem("--Select PINO--", "-1");
                    ddlPINO.Items.Insert(0, item);
                }
                else if (lUserID == 0 || lCompanyID == 0)
                {
                    Response.Redirect("~/Account/Login");
                }

                LoadPI(lUserID, lCompanyID);
            }
        }

        protected void btnShowReport_Click(object sender, EventArgs e)
        {
            if (ddlPINO.SelectedValue != "0")
            {
                ReportViewer1.Report = new rptPI();
                (ReportViewer1.Report as rptPI).pramPINo = ddlPINO.SelectedValue.ToString();
                ReportViewer1.RefreshReport();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "myScript", "WarningMessage();", true);

                ReportViewer1.Report = new rpt_HDOMasterDetail();

                //(ReportViewer1.Report as rpt_HDOMasterDetail).pramHDONo = ddlHDONo.SelectedValue.ToString();// "PI-00000155-Revise-2";
                ReportViewer1.RefreshReport();
            }
        }
        protected void LoadPI(int lUserID, int companyID)
        {
            List<vmPIMaster> lstSalPIMaster = objPIMgt.GetPIMasterByPIActive()
                 .Select(m => new vmPIMaster
                 {
                     PIID = m.PIID,
                     PINO = m.PINO,
                     CreateBy = m.CreateBy,
                     IsActive = true,
                     IsDeleted = false,
                     CompanyID = m.CompanyID
                 })
                 .Where(m => m.CompanyID == companyID).OrderByDescending(m => m.PIID).ToList();
            ddlPINO.DataSource = lstSalPIMaster;
            ddlPINO.DataValueField = "PINO";
            ddlPINO.DataTextField = "PINO";
            ddlPINO.DataBind();

            ListItem item = new ListItem("--Select PINO--", "-1");
            ddlPINO.Items.Insert(0, item);
        }

        protected void LoadCompany(int lUserID, int companyID)
        {          
            List<CmnCompany> lstCmnCompany = objPIMgt.GetPICompany(lUserID).Select(m => new CmnCompany { CompanyID = m.CompanyID, CompanyName = m.CompanyName, IsDeleted = m.IsDeleted }).ToList();
            ddlCompany.DataSource = lstCmnCompany;
            ddlCompany.DataValueField = "CompanyID";
            ddlCompany.DataTextField = "CompanyName";

            ddlCompany.DataBind();

            int lCompanyID = Convert.ToInt16(Session["CompanyID"]);
            ddlCompany.SelectedValue = lCompanyID.ToString();
            //ListItem item = new ListItem("--Select Company--", "-1");
            //ddlCompany.Items.Insert(0, item);

        }

        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            int companyID = Convert.ToInt16(ddlCompany.SelectedValue);
            if (companyID > 0)
            {
                LoadPI(Convert.ToInt16(Session["UserID"]), companyID);
            }
        }       
    }
}