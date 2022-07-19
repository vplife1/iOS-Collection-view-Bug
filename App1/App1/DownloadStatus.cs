using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public enum DownloadStatus
    {
        Unknown,
        Pending,
        Started,
        InProgress,
        Finished,
        Canceled,
        Error,
        Default
    }
}
