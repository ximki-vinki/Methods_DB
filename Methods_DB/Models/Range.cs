using System.Collections.Generic;

namespace Methods_DB.Models
{
    /// <summary>Диапазон методики</summary>
    internal struct Range
    {
        SubRanges FirstRange { get; set; }
        SubRanges LastRange { get; set; }
        public IEnumerable<SubTypeObject> CountSybTypeObjectsInRange { get; set; }
        public IEnumerable<ParametrSynonyms> CountParSynInRange { get; set; }
    }
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
}
