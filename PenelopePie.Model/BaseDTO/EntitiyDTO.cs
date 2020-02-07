using System;
namespace PenelopePie.Model.BaseDTO
{
    public class EntitiyDTO
    {
        public Guid EntitiesId { get; set; }
        public string EntitiesName { get; set; }
        public Guid? ProjectId { get; set; }
    }
}
