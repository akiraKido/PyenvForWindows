using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PyenvForWindows
{
    public partial class MainForm : Form
    {
        private PythonDirectoryInfo[] installedPythonInfos;


        public MainForm()
        {
            InitializeComponent();

            DisplayInstalledPythons();
        }

        private void DisplayInstalledPythons()
        {
            var installedPythons = Directory.GetDirectories(@"C:\Python");

            var infos = installedPythons.Select(
                installedPython =>
                new PythonDirectoryInfo(
                    Path.GetFileName(installedPython),
                    installedPython)
                ).ToArray();

            foreach (var info in infos)
            {
                InstalledPython_ListBox.Items.Add(info.Name);
            }

            installedPythonInfos = infos;
        }

        private class PythonDirectoryInfo
        {
            internal string Name { get; }
            internal string Path { get; }

            internal PythonDirectoryInfo(string name, string path)
            {
                Name = name;
                Path = path;
            }
        }
    }
}
