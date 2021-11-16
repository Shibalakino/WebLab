using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLab.Data.Models;

namespace WebLab.Data.interfaces
{
    public interface IGameCategory
    {
        IEnumerable<Category> AllCategories { get; }


    }
}
