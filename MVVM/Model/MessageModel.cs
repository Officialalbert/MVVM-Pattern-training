using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfResist.MVVM.Model
{
    internal class MessageModel
    {
        public string UserName { get; set; }
        public string Message { get; set; } 

        public bool MyProperty { get; set; }
        public DateTime Time { get; set; }
    }
}
