using System.Collections.Generic;
namespace PenelopePie.Model.Validations
{
    public interface IDTOValidatons
    {
        bool IsValidated { get; set; }
        List<string> ValidationErrors { get; set; }
    }
}
