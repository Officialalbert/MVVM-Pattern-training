using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfResist.MVVM.Model
{
    internal class UserModel
    {
        public string Names { get; set; } 

        public int ID { get; set; }

        public string PictureSource { get; set; }
        ObservableCollection<MessageModel> messages { get; set; }

        public string lastmessage => messages.Last().Message;
                
    }
}
