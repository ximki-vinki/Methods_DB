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
        public IEnumerable<Range> Ranges { get; set; }
        public IEnumerable<ObjectMethod> ObjectsMethod { get; set; }
        ItemDocument MethodDoc { get; set; }

    }

    #region Диапазон измерения методики и ед. измерения
    /// <summary>Диапазон методики</summary>
    internal struct Range
    {
        SubRanges FirstRange { get; set; }
        SubRanges LastRange { get; set; }
        public IEnumerable<SybTypeObject> IncludSybTypeObjects { get; set; }

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
    internal struct ObjectMethod
    {
        public string FullNameObject { get; set; }
        public IEnumerable<SybTypeObject> IncludSybTypeObjects { get; set; }
    }
    #endregion
    #region Документ
    /// <summary>Тип документа:ГОСТ</summary>
    internal class TypeDocument
    {
        public string NameTypeDocument { get; set; }
    }
    internal class Document : TypeDocument
    {
        public string NumberDoc { get; set; }
        YearInDoc YearInNameDoc { get; set; }
        public DateTime ImplementationDate { get; set; }
        public bool IsDocumentCurrent { get; set; }
    }
    internal class ItemDocument : Document
    {
        public string NumberItemDoc { get; set; }
    }
    /// <summary>Дата в названии документа 99 или 1999</summary>
    public struct YearInDoc
    {
        public DateTime DateAsYear { get; set; }
        public bool YearIsFull { get; set; }
    } 
    #endregion




}
