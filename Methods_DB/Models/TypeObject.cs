using System.Collections.Generic;

namespace Methods_DB.Models
{

    /// <summary>Глобальный обЪект исследования :Вода</summary>
    internal class GlobalTypeObject
    {
        public string Name { get; set; }

        public ICollection<TypeObject> CountTypeObjects { get; set; }
    }
    /// <summary> Объект исследования :Вода сточная </summary>
    internal class TypeObject : GlobalTypeObject
    {
        
        public ICollection<SubTypeObject> CountSybTypeObjects { get; set; }
    }
    /// <summary>Суб объект исследования :Вода сточная очищенная</summary>
    internal class SubTypeObject : TypeObject
    {
           }
    internal struct ObjectMethod
    {
        public string Name { get; set; }

        public ICollection<SubTypeObject> IncludSybTypeObjects { get; set; }
    }
}
