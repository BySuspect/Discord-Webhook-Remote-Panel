using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWebhookRemotePanel.Helpers
{
    public class FilePathData
    {
        public string tempPath = Path.GetTempPath();
        public readonly string folderPath = @"DiscordWebhooks\";
    }
}
