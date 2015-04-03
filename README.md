# FFmpeg-helper
using ffmpeg decode video

# AppSettings
ffmepg = "D:\ffmpeng.exe" <br/>
args = "-i {0} -c:v libx264 -crf 24 {1}" <br/>
flv = "D:\"
{0} = "D\:test.mp4"
{1} = flv + "test.flv"
 
the whole command looks like: 
"D:\ffmpeng.exe" -i "D\:test.mp4" -c:v libx264 -crf 24 "D:\test.flv"
