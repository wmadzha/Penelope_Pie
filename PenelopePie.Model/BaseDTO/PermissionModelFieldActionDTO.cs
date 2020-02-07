using System;
namespace PenelopePie.Model.BaseDTO
{
    public class PermissionModelFieldActionDTO
    {
        public Guid PermissionModelPropertiesActionId { get; set; }
        public string ActionType { get; set; }
        public string FieldName { get; set; }
        public string ModelName { get; set; }
        public string GrantType { get; set; }
        public Guid? EntityFieldsId { get; set; }
        public Guid? EntitiesId { get; set; }
    }
}
