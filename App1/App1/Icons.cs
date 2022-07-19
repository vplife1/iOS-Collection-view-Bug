using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public static class Icons
    {
        //Please add glyph in collection as well to get in xaml as dynamic resources.
        public const string Setting = "\uE8B8";
        public const string DropDownCircle = "\uE5C6";
        public const string DropDown = "\uE5C5";
        public const string DropUp = "\uE5C7";
        public const string Close = "\uE5CD";
        public const string Call = "\uE0B0";
        public const string Place = "\uE55F";
        public const string Lock = "\uE897";
        public const string Warning = "\uE002";
        public const string Location = "\uE0C8";
        public const string DefaultProfile = "\uE7Fd";
        public const string Delete = "\uE92B";
        public const string DeleteBefore = "\uE92E";
        public const string Add = "\uE145";
        public const string Check = "\uE5CA";
        public const string Calendar = "\uE935";
        public const string Search = "\uE8B6";
        public const string NavBack = "\uE5C4";
        public const string Substract = "\uE15B";
        public const string CheckCircle = "\uE86C";
        public const string AddCircle = "\uE148";
        public const string ChevronRight = "\uE5CC";
        public const string MoreHoriz = "\uE5D3";
        public const string UpArrow = "\uE316";
        public const string DownArrow = "\uE313";
        public const string Download = "\uE2C0";
        public const string SelectedCheck = "\uE862";
        public const string BottomBarDashBoard = "\uE1B2";
        public const string BottomBarCall = "\uE943";
        public const string BottomBarCheckList = "\uE86C";
        public const string BottomBarWrapUp = "\uE153";
        public const string BottomBarExtras = "\uE5C3";
        public const string LockOpen = "\uE898";
        public const string Selected = "\uE876";
        public const string CloudDownload = "\uE2C0";
        public const string NavigateBack = "\uE408";
        public const string PowerSettings = "\ue8ac";
        public const string RightArrow = "\uE409";
        public const string Refresh = "\uE86a";
        public const string ArrowDropDown = "\uE5C5";
        public const string ArrowDropUp = "\uE5C7";
        public const string FolderOpen = "\uE2C8";
        public const string Restore = "\uE8B3";
        public const string MenuBook = "\uEA19";
        public const string Remove = "\uE15b";
        public const string ArrowLeft = "\uE5DE";
        public const string ArrowRight = "\uE5DF";
        public const string Edit = "\uE3C9";
        public const string DragIndicator = "\uE945";
        public const string Attachment = "\uE226";

        //Dashboard icons
        public const string FastFood = "\uE57A";
        public const string Camera = "\uE3B0";
        public const string MonetizationOn = "\uE263";
        public const string Notifications = "\uE7F4";
        public const string InsertInvitation = "\uE24F";
        public const string FileCopy = "\uE173";
        public const string Info = "\uE88E";
        public const string Ballot = "\uE172";
        public const string Description = "\uE873";
        public const string Email = "\uE0BE";
        public const string WatchLater = "\uE924";
        public const string Group = "\uE7EF";
        public const string HelpOutline = "\uE8FD";

        public const string Cached = "\uE86A";
        public const string FiberManualRecord = "\uE061";

        //Extra Menu
        public const string SwipeHorizontal = "\uE8d4";
        public const string ContentCopy = "\uE14d";
        public const string Create = "\uE150";
        public const string Assignment = "\uE85d";
        public const string BulletList = "\uE241";
        public const string SaveAlt = "\uE171";
        public const string Assessment = "\uE85c";
        public const string ChevronLeft = "\uE5cb";
        public const string BarChart = "\uE26b";

        //Depart
        public const string DepartPrint = "\ue8ad";
        public const string Cancel = "\ue5c9";

        //Parts
        public const string CheckBoxOutline = "\uE835";
        public const string CheckBox = "\uE834";
        public const string RadioButtonChecked = "\uE837";
        public const string RadioButtonUnChecked = "\uE836";

        /// <summary>
        /// This method provides All Glyphs in Dictionary
        /// </summary>
        private static Dictionary<string, string> _allFontIcons;
        public static Dictionary<string, string> GetAllGlyphs()
        {
            if (_allFontIcons == null)
            {
                _allFontIcons = new Dictionary<string, string>
                {
                    { nameof (Setting), Setting },
                    { nameof (DropDownCircle), DropDownCircle },
                    { nameof (DropDown), DropDown },
                    { nameof (DropUp), DropUp },
                    { nameof (Close), Close },
                    { nameof (Call), Call },
                    { nameof (Place), Place },
                    { nameof (Lock), Lock },
                    { nameof (Warning), Warning },
                    { nameof (Location), Location },
                    { nameof (DefaultProfile), DefaultProfile },
                    { nameof (Delete), Delete },
                    { nameof(DeleteBefore),DeleteBefore},
                    { nameof (Add), Add },
                    { nameof (Check), Check },
                    { nameof (Calendar), Calendar },
                    { nameof (Substract), Substract },
                    { nameof (Search), Search },
                    { nameof (CheckCircle), CheckCircle },
                    { nameof (AddCircle), AddCircle },
                    { nameof (ChevronRight), ChevronRight },
                    { nameof (NavBack), NavBack },
                    { nameof (MoreHoriz), MoreHoriz },
                    { nameof (UpArrow), UpArrow },
                    { nameof (DownArrow), DownArrow },
                    { nameof (Download), Download },
                    { nameof (SelectedCheck), SelectedCheck },
                    { nameof (BottomBarDashBoard), BottomBarDashBoard },
                    { nameof (BottomBarCheckList), BottomBarCheckList },
                    { nameof (BottomBarCall), BottomBarCall },
                    { nameof (BottomBarWrapUp), BottomBarWrapUp },
                    { nameof (BottomBarExtras), BottomBarExtras },
                    { nameof (LockOpen), LockOpen },
                    { nameof (Selected), Selected },
                    { nameof (CloudDownload), CloudDownload },
                    { nameof (NavigateBack), NavigateBack },
                    { nameof (PowerSettings), PowerSettings },
                    { nameof (FastFood), FastFood },
                    { nameof (Camera), Camera },
                    { nameof (MonetizationOn), MonetizationOn },
                    { nameof (Notifications), Notifications },
                    { nameof (InsertInvitation), InsertInvitation },
                    { nameof (FileCopy), FileCopy },
                    { nameof (Info), Info },
                    { nameof (Ballot), Ballot },
                    { nameof (Description), Description },
                    { nameof (Email), Email },
                    { nameof (WatchLater), WatchLater },
                    { nameof (Group), Group },
                    { nameof (HelpOutline), HelpOutline },
                    { nameof (RightArrow), RightArrow },
                    { nameof (Refresh), Refresh },
                    { nameof (ArrowDropDown), ArrowDropDown },
                    { nameof (ArrowDropUp), ArrowDropUp },
                    { nameof (Cached), Cached },
                    { nameof (FiberManualRecord), FiberManualRecord },
                    { nameof (FolderOpen), FolderOpen },
                    { nameof (Restore), Restore},
                    { nameof (MenuBook), MenuBook},
                    { nameof (SwipeHorizontal), SwipeHorizontal },
                    { nameof(ContentCopy),ContentCopy},
                    { nameof(Create),Create},
                    { nameof(BulletList),BulletList},
                    {nameof(Assignment),Assignment },
                    {nameof(SaveAlt),SaveAlt },
                    {nameof(Assessment),Assessment },
                    {nameof(Remove),Remove },
                    {nameof(ArrowLeft),ArrowLeft },
                    {nameof(ArrowRight),ArrowRight },
                    {nameof(Edit),Edit },
                    {nameof(ChevronLeft),ChevronLeft },
                    {nameof(DragIndicator),DragIndicator },
                    {nameof(BarChart),BarChart },
                    {nameof(DepartPrint),DepartPrint },
                    {nameof(Cancel),Cancel },
                    {nameof(CheckBoxOutline),CheckBoxOutline },
                    {nameof(CheckBox),CheckBox },
                    {nameof(RadioButtonChecked),RadioButtonChecked },
                    {nameof(RadioButtonUnChecked),RadioButtonUnChecked },
                    {nameof(Attachment), Attachment }
                };
            }
            return _allFontIcons;
        }
    }

    public enum IconFont
    {
        RegularIconFont,
        OutlineIconFont
    }
}
