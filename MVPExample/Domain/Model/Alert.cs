using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Alert
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public Icon Icon { get; set; }
        public bool Favorite { get; set; }
        public bool NeedsConfirmation { get; set; }
        public int DisplayTime { get; set; } = 10;
    }
}
