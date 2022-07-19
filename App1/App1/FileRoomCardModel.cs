using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace App1
{
    public class FileRoomCardModel : INotifyPropertyChanged
    {
        public FileRoomCardModel() { }
        public string FileName { get; set; }

        public string Reference { get; set; }

        public string Category { get; set; }

        public string Created { get; set; }
        public int ImageSeqNo { get; set; }

        public bool IsDownloaded { get; set; }
        public ImageSource CardBackgroundImage { get; set; }
        public bool CardBackgroundImageVisible { get; set; }
        public ImageSource DownloadButtonImage { get; set; }
        public bool DownloadButtonVisible { get; set; }
        public Color DownloadBtnBGColor { get; set; }
        public Color DownloadBtnBorderColor { get; set; }
        private DownloadStatus _downloadMode;
        public DownloadStatus DownloadMode
        {
            get { return _downloadMode; }
            set { _downloadMode = value; NotifyPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
