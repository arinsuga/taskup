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
    [Table("MST01CFG_BLOODTYPE")]
    public partial class Bloodtype : CRUD
    {
        public int? DTA_STS { get; set; }
        public string BLOODTYPE_CODE { get; set; }
        public string BLOODTYPE_SHORTDESC { get; set; }
        public string BLOODTYPE_DESC { get; set; }
        public int? BLOODTYPE_SEQNO { get; set; }
    } //End public partial class Bloodtype : CRUD
} //End namespace APPBASE.Models
