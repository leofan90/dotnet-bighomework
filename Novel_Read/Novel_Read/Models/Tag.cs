using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsharpBigHomework.Models
{
    public class Tag
    {
        public string TagId { get; set; }
        public string TagName { get; set; }

        public Tag()
        {

        }

        public Tag(string tagName)
        {
            this.TagId = Guid.NewGuid().ToString();
            this.TagName = tagName;
        }
    }
}
