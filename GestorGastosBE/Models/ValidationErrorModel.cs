using System.Collections.Generic;

namespace GestorGastosBE.Api.Models
{
    public class ValidationErrorModel
    {
        public string FieldName { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
