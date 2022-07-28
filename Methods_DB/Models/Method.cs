using System.Collections.Generic;


namespace Methods_DB.Models
{
    internal class Method
    {
        public string NameMethod { get; set; }

        public ICollection<Range> Ranges { get; set; }

        public ICollection<ObjectMethod> ObjectsMethod { get; set; }

        ItemDocument MethodDoc { get; set; }
            }
 
}
