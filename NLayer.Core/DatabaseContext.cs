using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class DatabaseContext
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Number { get; set; }

    }
}
