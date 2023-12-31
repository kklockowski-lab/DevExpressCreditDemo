﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DevExpressCreditDemo.credit
{

    public partial class Repayment : XPLiteObject
    {
        long fID;
        [Key(true)]
        public long ID
        {
            get { return fID; }
            set { SetPropertyValue<long>(nameof(ID), ref fID, value); }
        }
        Agreement fIDAgreement;
        [Association(@"RepaymentReferencesAgreement")]
        public Agreement IDAgreement
        {
            get { return fIDAgreement; }
            set { SetPropertyValue<Agreement>(nameof(IDAgreement), ref fIDAgreement, value); }
        }
        string fDate;
        [Size(SizeAttribute.Unlimited)]
        public string Date
        {
            get { return fDate; }
            set { SetPropertyValue<string>(nameof(Date), ref fDate, value); }
        }
        double fValue;
        public double Value
        {
            get { return fValue; }
            set { SetPropertyValue<double>(nameof(Value), ref fValue, value); }
        }

        public DateTime DateOfPaid { get { return DateTime.Parse(fDate); } }
    }

}
