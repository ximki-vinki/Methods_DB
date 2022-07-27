using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_DB.Models
{
    internal class Method
    {
        public string NameMethod { get; set; }
        public IEnumerable<Range> Rangfes { get; set; }


    }

    #region Диапазон измерения методики и ед. измерения
    /// <summary>Диапазон методики</summary>
    internal struct Range
    {
        SubRanges FirstRange { get; set; }
        SubRanges LastRange { get; set; }
    }
    /// <summary>Один из диапазонов методики</summary>
    internal struct SubRanges
    {
        public int NumSubRange { get; set; }
        /// <summary>Включает ли диапазон число</summary>
        public bool IncluedNum { get; set; }
        public int СoeffSubRange { get; set; }
        public IEnumerable<UnitOfMeasurement> SubRangeUoM { get; set; }
    }
    /// <summary>Еденица измерений</summary>
    internal struct UnitOfMeasurement
    {
        public string NameUoM { get; set; }
        public int СoeffUoM { get; set; }
    }
    #endregion

    #region ОбЪекты исследования
    /// <summary>Глобальный обЪект исследования :Вода</summary>
    internal class GlobalTypeObject
    {
        public IEnumerable<TypeObject> CountTypeObjects { get; set; }
    }
    /// <summary> Объект исследования :Вода сточная </summary>
    internal class TypeObject : GlobalTypeObject
    {
        public IEnumerable<SybTypeObject> CountSybTypeObjects { get; set; }
    }
    /// <summary>Суб объект исследования :Вода сточная очищенная</summary>
    internal class SybTypeObject : TypeObject
    {

    }
    internal struct Object
    {
        public string FullNameObject { get; set; }
        public IEnumerable<SybTypeObject> IncludSybTypeObjects { get; set; }
    } 
    #endregion

}
