using System;

namespace Methods_DB.Models
{
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

}
