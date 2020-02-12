using System;
using System.Collections.Generic;
using System.Text;

namespace PenelopePie.Model.Validations
{
    public abstract class WebApiDTOValidations : IDTOValidatons
    {
        public bool IsValidated { get; set; }
        public List<string> ValidationErrors { get; set; }
        public WebApiDTOValidations()
        {
            this.IsValidated = false;
            this.ValidationErrors = new List<string>();
        }
    }
}
