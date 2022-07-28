using System.Collections.Generic;


namespace Methods_DB.Models
{
    internal class Method
    {
        public string NameMethod { get; set; }
        public IEnumerable<Range> Ranges { get; set; }
        public IEnumerable<ObjectMethod> ObjectsMethod { get; set; }
        ItemDocument MethodDoc { get; set; }

    }
 
}
