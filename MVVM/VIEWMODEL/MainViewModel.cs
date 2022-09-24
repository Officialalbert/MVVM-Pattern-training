using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfResist.Core;
using WpfResist.MVVM.Model;

namespace WpfResist.MVVM.VIEWMODEL
{
    internal class MainViewModel : Inotify
    {
        public ObservableCollection<MessageModel> messageModels { get; set; }

        public ObservableCollection<UserModel> userModel { get; set; }

        public UserModel SelectedUser { get; set; }

        public Acting SelectedCommand{ get; set; }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { 
                _message = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel() 
        {
            messageModels = new ObservableCollection<MessageModel>();
            userModel = new ObservableCollection<UserModel>();

            SelectedCommand = new Acting(x =>
            {
                messageModels.Add(new MessageModel
                {
                    Message = Message,
                    MyProperty = false
                });
                Message = "";
            });

            messageModels.Add(new MessageModel
            {
                UserName = "John",
                Message = "Hi Man you are a man. Don't gossip. you are good",
                Time = DateTime.Now,
            });

            userModel.Add(new UserModel
            {
                Names = "Johnatan"
            });
        }
    }
}
