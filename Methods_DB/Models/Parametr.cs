using System.Collections.Generic;

namespace Methods_DB.Models
{
    
    internal class Type_Parametr
    {
        public string NameTypePar { get; set; }
        public IEnumerable<ParametrSynonyms> CountParSyn { get; set; }

    }
    internal class ParametrSynonyms : Type_Parametr
    {
        public string NameParSyn { get; set; }
    }
    
}
