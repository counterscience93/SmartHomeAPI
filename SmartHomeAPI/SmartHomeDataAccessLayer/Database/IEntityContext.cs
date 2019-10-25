using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDataAccessLayer.Database
{
    public interface IEntityContext
    {
        object GetContext { get; }
    }
}
