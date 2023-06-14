using SwadeshProperties_DocumentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwadeshProperties_DocumentManagement.ViewModels
{
    public class DocumentCategoryData
    {
        public DocumentCategoryInfo DocumentCategoryInfo { get; set; } 
        public List<DocumentCategoryInfo> Data { get; set; }

    }
}