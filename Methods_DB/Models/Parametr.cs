using System.Collections.Generic;

namespace Methods_DB.Models
{
    internal class Type_Parametr
    {
        public string Name { get; set; }

        public ICollection<ParametrSynonyms> CountParSyn { get; set; }

    }
    internal class ParametrSynonyms : Type_Parametr
    {
    }
}
