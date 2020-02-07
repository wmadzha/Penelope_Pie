using System;
namespace PenelopePie.Model.BaseDTO
{
    public  class PermissionModelActionDTO
    {
        public Guid PermissionModelActionId { get; set; }
        public string ModelName { get; set; }
        public string ActionType { get; set; }
        public string GrantType { get; set; }
        public Guid? EntitiesId { get; set; }
    }
}
