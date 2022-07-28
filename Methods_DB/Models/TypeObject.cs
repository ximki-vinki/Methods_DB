using System.Collections.Generic;

namespace Methods_DB.Models
{

    /// <summary>Глобальный обЪект исследования :Вода</summary>
    internal class GlobalTypeObject
    {
        public string NameGTO { get; set; }

        public IEnumerable<TypeObject> CountTypeObjects { get; set; }
    }
    /// <summary> Объект исследования :Вода сточная </summary>
    internal class TypeObject : GlobalTypeObject
    {
        public string NameTypeObject { get; set; }

        public IEnumerable<SubTypeObject> CountSybTypeObjects { get; set; }
    }
    /// <summary>Суб объект исследования :Вода сточная очищенная</summary>
    internal class SubTypeObject : TypeObject
    {
        public string NameSubTypeObject { get; set; }
    }
    internal struct ObjectMethod
    {
        public string FullNameObject { get; set; }

        public IEnumerable<SubTypeObject> IncludSybTypeObjects { get; set; }
    }
}
