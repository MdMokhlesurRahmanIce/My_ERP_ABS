using System;

namespace ABS.Reports.Accounting
{
    /// <summary>
    /// Summary description for CashPaymentStatReport.
    /// </summary>
    public partial class ContraStatReport : Telerik.Reporting.Report
    {
        public ContraStatReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public DateTime pvparam
        {
            get
            {
                return (DateTime)sqlDataSource1.Parameters[0].Value;
            }
            set
            {
                sqlDataSource1.Parameters[0].Value = value;
            }

        }
        public DateTime pvparam1
        {
            get
            {
                return (DateTime)sqlDataSource1.Parameters[1].Value;
            }
            set
            {
                sqlDataSource1.Parameters[1].Value = value;
            }

        }
        public string pvparam2
        {
            get
            {
                return (string)sqlDataSource1.Parameters[2].Value;
            }
            set
            {
                sqlDataSource1.Parameters[2].Value = value;
            }

        }
 
        public string pvparam4
        {
            get
            {
                return (string)sqlDataSource1.Parameters[3].Value;
            }
            set
            {
                sqlDataSource1.Parameters[3].Value = value;
            }

        }
    }
}