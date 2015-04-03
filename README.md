# FFmpeg-helper
using ffmpeg decode video

# AppSettings
ffmepg = "D:\ffmpeng.exe" <br/>
args = "-i {0} -c:v libx264 -crf 24 {1}" <br/>
flv = "D:\" <br/>
{0} = "D\:test.mp4" <br/>
{1} = flv + "test.flv" <br/>
<br/>
the whole command looks like: <br/>
"D:\ffmpeng.exe" -i "D\:test.mp4" -c:v libx264 -crf 24 "D:\test.flv"
