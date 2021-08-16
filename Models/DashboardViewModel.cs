using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eos.Models
{
    public class DashboardViewModel
    {
        public Post post { get; set; }

        public IEnumerable<Post> postLista { get; set; }
    }
}
