﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcapp;

namespace APPBASE.Models
{
    public partial class MaritalVM
    {
        public int? ID { get; set; }
        public int? DTA_STS { get; set; }
        public string MARITAL_CODE { get; set; }
        public string MARITAL_SHORTDESC { get; set; }
        public string MARITAL_DESC { get; set; }
        public int? MARITAL_SEQNO { get; set; }
    } //End public partial class MaritalVM
} //End namespace APPBASE.Models
