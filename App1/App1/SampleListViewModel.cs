using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1
{
    public class SampleListViewModel : INotifyPropertyChanged
    {
        #region Properys

        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<FileRoomCardModel> _customeFileRoomList;
        public ObservableCollection<FileRoomCardModel> CustomeFileRoomList
        {
            get
            {
                return _customeFileRoomList;
            }
            set
            {
                _customeFileRoomList = value;
                OnPropertyChanged(nameof(CustomeFileRoomList));
            }
        }
        #endregion

        #region Constructor
        public SampleListViewModel()
        {         
        }
        #endregion

        #region Command
        public ICommand DownloadCommand => new Command((stack) => DownloadAsync(stack));
        #endregion

        #region Command Exicution
        private void DownloadAsync(object stack)
        {
            try
            {
                List<FileRoomCardModel> customeFile = new List<FileRoomCardModel>();
                FileCardViewControl button = stack as FileCardViewControl;
                var dd = button.BindingContext as FileRoomCardModel;
                if (dd != null)
                {
                    foreach (var item in CustomeFileRoomList)
                    {
                        if (item.FileName == dd.FileName)
                        {
                            //item.CardBackgroundImage = null;
                            //item.CardBackgroundImageVisible = false;                         
                            item.DownloadMode = DownloadStatus.Finished;
                        }
                        customeFile.Add(item);
                    }
                    if (customeFile?.Count > 0)
                    {
                        CustomeFileRoomList = new ObservableCollection<FileRoomCardModel>(customeFile);
                    }
                }

            }
            catch (Exception ex)
            {
            }
        }
        #endregion

        #region Public Method
        public void MockData()
        {
            List<FileRoomCardModel> customeFileRoom = new List<FileRoomCardModel>();
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne1.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne2.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne3.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne4.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne5.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne6.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne7.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne8.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne9.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne00.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne09.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne98.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne12.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne123.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne4355.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne53.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne545645.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne34.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne233.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne2321.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne122.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "background_stripe_static.svg" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "background_stripe_static.png" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "background_stripe_static.png" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "background_stripe_static.png" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "background_stripe_static.png" : "downloading_stripes.gif", });
            customeFileRoom.Add(new FileRoomCardModel { FileName = "SampleOne.Png", CardBackgroundImageVisible = true, CardBackgroundImage = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "background_stripe_static.png" : "downloading_stripes.gif", });
          


            CustomeFileRoomList = new ObservableCollection<FileRoomCardModel>(customeFileRoom);
        }
        #endregion

        #region Protected Method
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}
