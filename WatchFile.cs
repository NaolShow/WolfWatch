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
                this.Path = References.PlaylistsPath + Program.mainForm.playlistsList.Text + "\\" + name;

                if (Extension != ".web")
                {
                    var player = new WindowsMediaPlayer();
                    var clip = player.newMedia(this.Path + this.Extension);
                    this.Duration = TimeSpan.FromSeconds(clip.duration).ToString();
                }

                // Check updates
                if (WolfLib.Rasu.Get(this.Path + ".info", "video_file_version") != Application.ProductVersion)
                {
                    File.WriteAllText(this.Path + Application.ProductVersion + ".info", Resources.video);
                    WolfLib.Rasu.MergeFile(this.Path + ".info", this.Path + Application.ProductVersion + ".info");
                    File.Delete(this.Path + ".info");
                    File.Move(this.Path + Application.ProductVersion + ".info", this.Path + ".info");
                    WolfLib.Rasu.Set(this.Path + ".info", "video_file_version", Application.ProductVersion);
                }

                this.Description = WolfLib.Rasu.Get(this.Path + ".info", "video_description");

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
