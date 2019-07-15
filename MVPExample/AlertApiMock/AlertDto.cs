using System;
using System.Collections.Generic;
using System.Text;

namespace AlertApiMock
{
    public class AlertDto
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Icon { get; set; }
        public bool Favorite { get; set; }
        public bool NeedsConfirmation { get; set; }
        public int DisplayTime { get; set; }
    }
}
