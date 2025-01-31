﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace MultiDownloader.ViewModels
{
    public class InstagramLoginViewModel : Screen
    {
        private string _buttonInstagramLoginContent;
        private string _backgroundWindowColor;
        private string _backgroundTopGridColor;
        private string _windowTitleText;
        private string _pictureBoxUserNameFilePath;
        private string _pictureBoxPasswordFilePath;
        private string _textBoxUserNameInstagramContent;
        private string _textBoxPasswordInstagramContent;
        private string _textBoxUserNameInstagramContentTag;
        private string _textBoxPasswordInstagramContentTag;

        public InstagramLoginViewModel()
        {
            ButtonInstagramLoginContent = "Login";
            BackgroundWindowColor = "#181745";
            BackgroundTopGridColor = "#0F0F2D";
            WindowTitleText = "Multi Downloader";
            PictureBoxUserNameFilePath = "../Resource/UserDark.png";
            PictureBoxPasswordFilePath = "../Resource/PasswordDark.png";
            TextBoxUserNameInstagramContentTag = "Uername/Email...";
            TextBoxPasswordInstagramContentTag = "Password...";
        }

        #region Properties
        
        public string ButtonInstagramLoginContent
        {
            get
            {
                return _buttonInstagramLoginContent;
            }
            set
            {
                _buttonInstagramLoginContent = value;
                NotifyOfPropertyChange(ButtonInstagramLoginContent);
            }
        }
        public string BackgroundWindowColor
        {
            get
            {
                return _backgroundWindowColor;
            }
            set
            {
                _backgroundWindowColor = value;
                NotifyOfPropertyChange(BackgroundWindowColor);
            }
        }
        public string BackgroundTopGridColor
        {
            get
            {
                return _backgroundTopGridColor;
            }
            set
            {
                _backgroundTopGridColor = value;
                NotifyOfPropertyChange(BackgroundTopGridColor);
            }
        }
        public string WindowTitleText
        {
            get
            {
                return _windowTitleText;
            }
            set
            {
                _windowTitleText = value;
                NotifyOfPropertyChange(WindowTitleText);
            }
        }
        public string PictureBoxUserNameFilePath
        {
            get
            {
                return _pictureBoxUserNameFilePath;
            }
            set
            {
                _pictureBoxUserNameFilePath = value;
                NotifyOfPropertyChange(PictureBoxUserNameFilePath);
            }
        }
        public string PictureBoxPasswordFilePath
        {
            get
            {
                return _pictureBoxPasswordFilePath;
            }
            set
            {
                _pictureBoxPasswordFilePath = value;
                NotifyOfPropertyChange(PictureBoxPasswordFilePath);
            }
        }
        public string TextBoxUserNameInstagramContent
        {
            get
            {
                return _textBoxUserNameInstagramContent;
            }
            set
            {
                _textBoxUserNameInstagramContent = value;
                NotifyOfPropertyChange(TextBoxUserNameInstagramContent);
            }
        }
        public string TextBoxPasswordInstagramContent
        {
            get
            {
                return _textBoxPasswordInstagramContent;
            }
            set
            {
                _textBoxPasswordInstagramContent = value;
                NotifyOfPropertyChange(TextBoxPasswordInstagramContent);
            }
        }
        public string TextBoxUserNameInstagramContentTag
        {
            get
            {
                return _textBoxUserNameInstagramContentTag;
            }
            set
            {
                _textBoxUserNameInstagramContentTag = value;
                NotifyOfPropertyChange(TextBoxUserNameInstagramContentTag);
            }
        }
        public string TextBoxPasswordInstagramContentTag
        {
            get
            {
                return _textBoxPasswordInstagramContentTag;
            }
            set
            {
                _textBoxPasswordInstagramContentTag = value;
                NotifyOfPropertyChange(TextBoxPasswordInstagramContentTag);
            }
        }

        #endregion

        #region Methods
        public void ButtonLogin()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new InstaLoginChallengeRequiredViewModel(), null, null);

        }


        #endregion
    }
}
