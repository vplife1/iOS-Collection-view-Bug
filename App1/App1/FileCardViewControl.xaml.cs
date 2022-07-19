using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FileCardViewControl : ContentView
    {
        public FileCardViewControl()
        {
            InitializeComponent();
            SetDownloadButtonUI();
        }
        private void SetDownloadButtonUI()
        {
            DownloadButton.ImageSource = new FontImageSource { Glyph = Icons.CloudDownload, FontFamily = IconFont.OutlineIconFont.ToString(), Color = Color.White};
            DownloadButton.BackgroundColor = Color.FromHex("#414F6A");
            DownloadButton.BorderColor = Color.White;
        }
        public static readonly BindableProperty DownloadButtonCommandProperty = BindableProperty.Create(
                                                        propertyName: nameof(DownloadButtonCommand),
                                                        returnType: typeof(ICommand),
                                                        declaringType: typeof(FileCardViewControl),
                                                        defaultValue: default(ICommand),
                                                        propertyChanged: DownloadButtonCommandPropertyChanged);

        public ICommand DownloadButtonCommand
        {
            get { return (ICommand)base.GetValue(DownloadButtonCommandProperty); }
            set { base.SetValue(DownloadButtonCommandProperty, value); }
        }
        private static void DownloadButtonCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is FileCardViewControl)
            {
                (bindable as FileCardViewControl).DownloadButton.Command = newValue as ICommand;
            }
        }
        public static readonly BindableProperty DownloadButtonCommandParameterProperty = BindableProperty.Create(
                                                        propertyName: nameof(DownloadButtonCommandParameter),
                                                        returnType: typeof(object),
                                                        declaringType: typeof(FileCardViewControl),
                                                        defaultValue: default(object),
                                                        propertyChanged: DownloadButtonCommandParameterPropertyChanged);

        public object DownloadButtonCommandParameter
        {
            get { return (object)base.GetValue(DownloadButtonCommandProperty); }
            set { base.SetValue(DownloadButtonCommandProperty, value); }
        }
        private static void DownloadButtonCommandParameterPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is FileCardViewControl)
            {
                (bindable as FileCardViewControl).DownloadButton.CommandParameter = newValue as object;
            }
        }
        //Bindable property for the Background Image
        public static readonly BindableProperty SetBackgroundImageProperty = BindableProperty.Create(
            propertyName: nameof(SetBackgroundImage),
            returnType: typeof(ImageSource),
            declaringType: typeof(FileCardViewControl),
            defaultValue: default(ImageSource),
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (bindable is FileCardViewControl)
                {
                    (bindable as FileCardViewControl).FileCardBGImage.Source = newValue as ImageSource;
                }
            });

        public ImageSource SetBackgroundImage
        {
            get => base.GetValue(SetBackgroundImageProperty) as ImageSource;
            set => base.SetValue(SetBackgroundImageProperty, value);
        }

        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(
           propertyName: nameof(CardTitle),
           returnType: typeof(string),
           declaringType: typeof(FileCardViewControl),
           defaultValue: string.Empty,
           propertyChanged: (bindable, oldValue, newValue) =>
           {
               if (bindable is FileCardViewControl)
               {
                   (bindable as FileCardViewControl).FrameName.Text = Convert.ToString(newValue);
               }
           });

        public string CardTitle
        {
            get => (string)GetValue(CardTitleProperty);
            set => SetValue(CardTitleProperty, value);
        }
        /// <summary>
        /// Bindable property to Background Image Visible
        /// </summary>
        public static readonly BindableProperty BackgroundImageVisibleProperty = BindableProperty.Create(
            propertyName: nameof(BackgroundImageVisible),
            returnType: typeof(bool),
            declaringType: typeof(FileCardViewControl),
            defaultValue: true,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (bindable is FileCardViewControl)
                {
                    (bindable as FileCardViewControl).FileCardBGImage.IsVisible = Convert.ToBoolean(newValue);
                }
            });

        public bool BackgroundImageVisible
        {
            get => Convert.ToBoolean(GetValue(BackgroundImageVisibleProperty));
            set => SetValue(BackgroundImageVisibleProperty, value);
        }


        public static readonly BindableProperty FileDownloadModeProperty = BindableProperty.Create(
                                                            propertyName: nameof(FileDownloadMode),
                                                            returnType: typeof(DownloadStatus),
                                                            declaringType: typeof(FileCardViewControl),
                                                            defaultValue: DownloadStatus.Unknown,
                                                            defaultBindingMode: BindingMode.TwoWay,
                                                            propertyChanged: FileDownloadModePropertyChanged);
        public DownloadStatus FileDownloadMode
        {
            get
            {
                return (DownloadStatus)base.GetValue(FileDownloadModeProperty);
            }
            set
            {
                base.SetValue(FileDownloadModeProperty, value);
            }
        }
        private static void FileDownloadModePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is FileCardViewControl && newValue != null)
            {
                var value = (DownloadStatus)newValue;
                if (oldValue != null && value == (DownloadStatus)oldValue)
                    return;

                var fileRoomCardView = (bindable as FileCardViewControl);

                if (DownloadStatus.Finished==value)
                {
                    fileRoomCardView.FileCardBGImage.IsVisible = false;
                    fileRoomCardView.FileCardBGImage.Source = null;
                    fileRoomCardView.DownloadButton.ImageSource = "camera.svg";
                   // fileRoomCardView.DownloadButton.BackgroundColor = Color.FromHex("#414F6A");
                    fileRoomCardView.DownloadButton.BorderColor = Color.Red;
                }
                //else
                //{
                //    fileRoomCardView.FileCardBGImage.IsVisible = true;
                //    fileRoomCardView.FileCardBGImage.Source = Xamarin.Essentials.DeviceInfo.Platform == DevicePlatform.iOS ? "bug.svg" : "downloading_stripes.gif";
                //    fileRoomCardView.DownloadButton.ImageSource = new FontImageSource { Glyph = Icons.CloudDownload, FontFamily = IconFont.OutlineIconFont.ToString(), Color = Color.White };                  
                //    fileRoomCardView.DownloadButton.BackgroundColor = Color.FromHex("#414F6A");
                //    fileRoomCardView.DownloadButton.BorderColor = Color.White;
                //}                             
            }
        }
    }


}