using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PyenvForWindows
{
    public partial class MainForm : Form
    {
        private DirectoryInfo pythonRootDirectory = new DirectoryInfo(@"C:\Python");

        public MainForm()
        {
            InitializeComponent();

            DisplayInstalledPythons();
        }

        private void DisplayInstalledPythons()
        {
            foreach (var info in pythonRootDirectory.GetDirectories())
            {
                InstalledPython_ListBox.Items.Add(info.Name);
            }
        }

        private void SwithTo_Button_Click(object sender, EventArgs e)
        {
            string selectedVersion;
            try
            {
                selectedVersion = InstalledPython_ListBox.SelectedItem.ToString();
            } catch (Exception) { return; }

            string selectedPythonPath = pythonRootDirectory.GetDirectories().First(info => info.Name == selectedVersion).FullName;
            
            // 環境変数の取得
            string pathString = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
            if (pathString == null)
            {
                Console.WriteLine("Could not achieve path.");
                return;
            }

            // 登録されている Path の一覧を取得
            var paths = pathString.Split(';');
            // 現在登録されている Python を環境変数から外す
            var newPaths = paths.Where(path => !path.Contains(pythonRootDirectory.FullName)).ToList();

            // 指定されたバージョンの Python を環境変数に登録
            newPaths.Add(selectedPythonPath);
            newPaths.Add(Path.Combine(selectedPythonPath, "Scripts"));

            // 環境変数を更新
            Environment.SetEnvironmentVariable("Path", string.Join(";", newPaths), EnvironmentVariableTarget.Machine);
        }
    }
}
