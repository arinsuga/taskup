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
    public partial class ProgressstsVM
    {
        public int? ID { get; set; }
        public int? DTA_STS { get; set; }
        public string PROGRESSSTS_CODE { get; set; }
        public string PROGRESSSTS_SHORTDESC { get; set; }
        public string PROGRESSSTS_DESC { get; set; }
        public int? PROGRESSSTS_SEQNO { get; set; }
    } //End public partial class ProgressstsVM
} //End namespace APPBASE.Models