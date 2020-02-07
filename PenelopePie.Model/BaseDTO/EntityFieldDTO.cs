using System;
namespace PenelopePie.Model.BaseDTO
{
    public class EntityFieldDTO
    {
        public Guid EntityFieldsId { get; set; }
        public Guid? EntitiesId { get; set; }
        public string FieldName { get; set; }
    }
}
