using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.model
{
    public class Recordings
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public string Text { get; set; }

        public string Name { get; set; }


    }
}
