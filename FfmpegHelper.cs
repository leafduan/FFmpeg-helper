using System;
using System.Configuration;
using System.IO;
// reference https://github.com/LeafDuan/WebPrint/tree/master/WebPrint.Framework
using WebPrint.Framework;
// reference https://github.com/LeafDuan/WebPrint/tree/master/WebPrint.Logging
using WebPrint.Logging;

namespace WebPrint.CameraServer.Helper
{
    public class FfmpegHelper
    {
        private static readonly ILogger Logger = LoggerHelper.GetLogger(typeof (FfmpegHelper));

        private static string Ffmpeg
        {
            get { return ConfigurationManager.AppSettings["ffmepg"]; }
        }

        private static string Args
        {
            get { return ConfigurationManager.AppSettings["args"]; }
        }

        private static string FlvPath
        {
            get { return ConfigurationManager.AppSettings["flv"]; }
        }

        public static string DecodeMp4ToFlv(string mp4, int timeout = 0)
        {
            var ffmpeg = "\"{0}\"".Formatting(Ffmpeg);
            var flv = Path.Combine(FlvPath, (Path.GetFileNameWithoutExtension(mp4) ?? string.Empty) + ".flv");
            var args = Args.Formatting("\"{0}\"".Formatting(mp4), "\"{0}\"".Formatting(flv));
            string output, error;
            if (timeout <= 0)
                timeout = 5*60*1000; // timeout = 5 minutes
            ProcessHelper.Process(ffmpeg, args, timeout, out output, out error);
            if (!error.IsNullOrEmpty())
            {
                Logger.Error("{0}{1} : {2}{0}".Formatting(Environment.NewLine, "FFmpeg", error));
            }

            return flv;
        }
    }
}
