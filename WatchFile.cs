using MetroFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using WolfWatch.Properties;
using WolfLib;

namespace WolfWatch
{
    public class WatchFile
    {

        public String Name { get; set; }

        public String Extension { get; set; }

        public String Path { get; }

        public String Description { get; set; }

        public String Duration { get; set; }

        public WatchFile(String name, String extension)
        {
            try
            {

                this.Name = name;
                this.Extension = extension;
                this.Path = Reference.PlaylistsPath + Program.mainForm.playlistsList.Text + "\\" + name;

                if (Extension != ".web")
                {
                    var player = new WindowsMediaPlayer();
                    var clip = player.newMedia(this.Path + this.Extension);
                    this.Duration = TimeSpan.FromSeconds(clip.duration).ToString();
                }

                Rasu VideoInfo = new Rasu(this.Path + ".info");

                // Check updates
                if (VideoInfo.Get("video_file_version") != Application.ProductVersion)
                {
                    Rasu VideoInfoTemplate = new Rasu(Resources.video);
                    VideoInfo.MergeFile(VideoInfoTemplate);

                    VideoInfoTemplate.Set("video_file_version", Application.ProductVersion);

                    File.WriteAllText(VideoInfo.GetFilePath(), VideoInfoTemplate.GetFileContent());
                    VideoInfo.ReloadFile();
                }

                this.Description = VideoInfo.Get("video_description");

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(Program.mainForm, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
