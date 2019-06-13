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
    [Table("MST01CFG_RELIGION")]
    public partial class Religion : CRUD
    {
        public int? DTA_STS { get; set; }
        public string RELIGION_CODE { get; set; }
        public string RELIGION_SHORTDESC { get; set; }
        public string RELIGION_DESC { get; set; }
        public int? RELIGION_SEQNO { get; set; }
    } //End public partial class Religion : CRUD
} //End namespace APPBASE.Models
