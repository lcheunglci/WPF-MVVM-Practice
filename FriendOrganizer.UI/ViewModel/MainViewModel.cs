﻿using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;
        }

        public void Load()
        {
            var friends = _friendDataService.GetAll();
            Friends.Clear();
            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }

        public ObservableCollection<Friend> Friends { get; set; }

        private Friend _selectedFriend;

        private IFriendDataService _friendDataService;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Friend SelectedFriend
        {
            get { return _selectedFriend; }
            set
            {
                _selectedFriend = value;
                OnPropertyChanged();
            }

        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
