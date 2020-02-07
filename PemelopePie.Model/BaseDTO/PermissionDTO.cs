using System;
namespace PemelopePie.Model.BaseDTO
{
    public  class PermissionDTO
    {
        public Guid PermissionId { get; set; }
        public string PermissionName { get; set; }
        public Guid? ProjectId { get; set; }
    }
}
