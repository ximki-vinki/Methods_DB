using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_DB.Models
{
    internal class Method
    {
        public string Name { get; set; }


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

}
