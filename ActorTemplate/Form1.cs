﻿// ***********************************************************************
// Solution         : EmbeddedTemplate
// Project          : ActorTemplate
// File             : Form1.cs
// Updated          : 2017-11-10 19:19
// ***********************************************************************
// <copyright>
//     Copyright © 2016 - 2017 Kolibre Credit Team. All rights reserved.
// </copyright>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace ActorTemplate
{
    public partial class Form1 : Form
    {
        private static List<TemplateConfiguration> s_configuration;

        private readonly string _replaceNameSpaces = "$NameSpaces$";
        private readonly string _replaceINameSpaces = "$INameSpaces$";
        private readonly string _replaceActorName = "$ActorName$";
        private readonly string _replaceActorInterfaceName = "$IActorName$";
        private readonly string _replaceActorStateName = "$ActorStateName$";
        private readonly string _replaceActorReminderName = "$ActorReminderName$";
        private readonly string _replaceActorServiceName = "$ActorServiceName$";
        private readonly string _replaceGuid = "$GUID$";

        private string _outputPath;

        public Form1()
        {
            InitializeComponent();

            //InitializeSkin();

            InitializeConfiguration();
        }

        private void InitializeSkin()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream($"{GetType().Namespace}.Skin.CalmnessColor1.ssk");
            skinEngine1.SkinStream = stream;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string projectName = txb_ActorName.Text;
            if (string.IsNullOrEmpty(projectName) || string.IsNullOrWhiteSpace(projectName))
            {
                MessageBox.Show(@"Actor Name cannot be null or empty.", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                return;
            }

            if (string.IsNullOrEmpty(_outputPath))
            {
                MessageBox.Show(@"Project Path cannot be null or empty.", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                return;
            }

            string[] projectNames = projectName.Split(',');

            foreach (string name in projectNames)
            {
                if (CreateProject(name))
                {
                    // 创建失败，删除已创建的文件

                    DeleteDirAndFiles($"{_outputPath}\\{name}");
                    DeleteDirAndFiles($"{_outputPath}\\{name}.Interfaces");

                    return;
                }
            }
        }

        private static void DeleteDirAndFiles(string dirPath)
        {
            if (Directory.Exists(dirPath))
            {
                string[] dirs = Directory.GetDirectories(dirPath);
                string[] files = Directory.GetFiles(dirPath);

                foreach (string dir in dirs)
                {
                    DeleteDirAndFiles(dir);
                }

                foreach (string file in files)
                {
                    File.Delete(file);
                }

                Directory.Delete(dirPath, true);
            }
        }

        [SuppressMessage("ReSharper", "ConvertIfStatementToConditionalTernaryExpression")]
        private bool CreateProject(string projectName)
        {
            if (!projectName.EndsWith("Actor", StringComparison.Ordinal))
            {
                projectName += "Actor";
            }

            string actorName;

            string[] projectNames = projectName.Split('.');
            if (projectNames.Length > 1)
            {
                actorName = projectNames.Last();
            }
            else
            {
                actorName = projectName;
            }

            string projectInterfaceName = $"{projectName}.Interfaces";
            string actorInterfaceName = $"I{actorName}";
            string actorState = $"{actorName.Replace("Actor", "")}State";
            string actorReminder = $"{actorName.Replace("Actor", "")}Reminder";
            string actorService = $"{actorName.Replace("Actor", "")}Service";

            // 判断项目是否已经存在
            if (Directory.Exists($"{_outputPath}\\{projectName}"))
            {
                MessageBox.Show($@"{projectName} is exist.", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                return false;
            }
            if (Directory.Exists($"{_outputPath}\\{projectInterfaceName}"))
            {
                MessageBox.Show($@"{projectInterfaceName} is exist.", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                return false;
            }

            if (s_configuration == null || s_configuration.Count == 0)
            {
                MessageBox.Show(@"Missing template configuration.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                return false;
            }

            List<TemplateConfiguration> configs = s_configuration.Where(t => t.ActorType == "StatefulActor").ToList();

            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (TemplateConfiguration config in configs)
            {
                string outputName = config.Output.Replace(_replaceActorName, actorName);
                outputName = outputName.Replace(_replaceActorInterfaceName, actorInterfaceName);
                outputName = outputName.Replace(_replaceActorStateName, actorState);
                outputName = outputName.Replace(_replaceActorReminderName, actorReminder);
                outputName = outputName.Replace(_replaceActorServiceName, actorService);
                outputName = outputName.Replace(_replaceNameSpaces, projectName);
                outputName = outputName.Replace(_replaceINameSpaces, projectInterfaceName);

                string path = $"{_outputPath}\\{outputName}";

                if (config.Type == "Folder")
                {
                    CreateFolderIfNotExists(path);
                    continue;
                }

                Stream stream = assembly.GetManifestResourceStream($"{GetType().Namespace}.{config.Sources.Replace("\\", ".")}");
                if (stream == null)
                {
                    MessageBox.Show($@"File {config.Sources} not exist.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    return false;
                }

                string content = new StreamReader(stream).ReadToEnd();

                content = content.Replace(_replaceNameSpaces, projectName);
                content = content.Replace(_replaceINameSpaces, projectInterfaceName);
                content = content.Replace(_replaceActorName, actorName);
                content = content.Replace(_replaceActorInterfaceName, actorInterfaceName);
                content = content.Replace(_replaceActorStateName, actorState);
                content = content.Replace(_replaceActorReminderName, actorReminder);
                content = content.Replace(_replaceActorServiceName, actorService);
                content = content.Replace(_replaceGuid, Guid.NewGuid().ToString());

                CreateFileIfNotExists(path);

                File.AppendAllText(path, content);
            }

            return true;
        }

        private static void CreateFileIfNotExists(string fileName)
        {
            FileInfo file = new FileInfo(fileName);
            if (!file.Exists)
            {
                DirectoryInfo directory = file.Directory;

                if (directory != null && !directory.Exists)
                {
                    directory.Create();
                }

                file.Create().Dispose();
            }
        }

        private static void CreateFolderIfNotExists(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private void InitializeConfiguration()
        {
            // 读取 TemplateConfig.xml 
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream($"{GetType().Namespace}.TemplateConfig.xml");
            if (stream == null)
            {
                MessageBox.Show(@"File TemplateConfig.xml not exist.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                return;
            }

            string configString = new StreamReader(stream).ReadToEnd();

            XmlDocument xmlDoc = new XmlDocument();
            XmlReader reader = XmlReader.Create(new StringReader(configString), new XmlReaderSettings { IgnoreComments = true });
            xmlDoc.Load(reader);

            XmlNode rootNode = xmlDoc.SelectSingleNode("TemplateSettings");
            if (rootNode == null || !rootNode.HasChildNodes)
            {
                return;
            }

            List<TemplateConfiguration> configurations = new List<TemplateConfiguration>();

            foreach (XmlNode templateSettingNode in rootNode.ChildNodes)
            {
                if (templateSettingNode.Attributes != null)
                {
                    string actorType = templateSettingNode.Attributes["Name"].InnerText;
                    foreach (XmlNode templateNode in templateSettingNode.ChildNodes)
                    {
                        if (templateNode.Attributes != null)
                        {
                            string type = templateNode.Attributes["Type"].InnerText;
                            string output = templateNode.Attributes["Output"].InnerText;
                            string source = type == "Folder" ? null : templateNode.Attributes["Source"].InnerText;

                            configurations.Add(new TemplateConfiguration
                            {
                                Type = type,
                                ActorType = actorType,
                                Output = output,
                                Sources = source
                            });
                        }
                    }
                }
            }

            s_configuration = configurations;
        }

        private void InitComboxItem()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>
            {
                { "Stateful Actor", "StatefulActor" },
                { "Stateless Actor", "StatelessActor" }
            };

            BindingSource bs = new BindingSource { DataSource = dic };

            cmb_ActorType.DataSource = bs;
            cmb_ActorType.ValueMember = "Value";
            cmb_ActorType.DisplayMember = "Key";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitComboxItem();

            string[] arg = Environment.GetCommandLineArgs();

            if (arg.Length > 1)
            {
                _outputPath = arg.Last().Replace("\"", "");
                txb_ProjectPath.Text = _outputPath;
            }
        }

        private void btn_SelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog { Description = @"请选择文件夹路径" };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _outputPath = txb_ProjectPath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}