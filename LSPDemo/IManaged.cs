using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo
{
    public interface IManaged : IEmployee
    {
        IEmployee Manager { get; set; }
        void AsignManager(IEmployee manager);
    }
}
