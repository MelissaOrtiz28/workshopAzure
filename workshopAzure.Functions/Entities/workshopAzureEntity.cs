using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace workshopAzure.Functions.Entities
{
    public class workshopAzureEntity : TableEntity // F12 y me crea varias propiedades
    {
        public int EmployeeId { get; set; }
        public DateTime RecordDate { get; set; }
        public bool RecordType { get; set; }
        public bool Consolidated { get; set; }
    }
}
