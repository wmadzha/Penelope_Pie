using System;
namespace PemelopePie.Model.BaseDTO
{
    public  class ModuleDTO
    {
        // Check If Data Definition Need To be checked Added ModuleId ;
        public Guid ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public string ModulePermissionPrefix { get; set; }
        public Guid? ProjectId { get; set; }
    }
}
