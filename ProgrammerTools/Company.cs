using ProgrammerTools.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerTools
{
    public class Company : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Branch> Branches { get; set; }
    }
}
