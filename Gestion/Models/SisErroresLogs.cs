using System;
using System.Collections.Generic;

namespace Gestion.Models
{
    public partial class SisErroresLogs
    {
        public string Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Modulo { get; set; }
        public string ErrorMessage { get; set; }
        public int ErrorSeverity { get; set; }
        public int ErrorState { get; set; }
    }
}
