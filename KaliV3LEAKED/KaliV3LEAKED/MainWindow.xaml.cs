using DiscordMessenger;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using KrnlAPI;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Forms;
using System.Xml;
using WeAreDevs_API;

namespace KalioWPFV3
{
    public partial class MainWindow : Window, IComponentConnector
    {
        private ExploitAPI wrdapi = new ExploitAPI();
        private KrnlApi krnlapi = new KrnlApi();
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;
        private int discordColor = 1;
        internal
        Border MainBorder;
        internal System.Windows.Controls.ListBox List;
        internal Border first;
        internal System.Windows.Controls.Label label1;
        internal Border Second;
        internal System.Windows.Controls.Image home;
        internal System.Windows.Controls.Image scripts;
        internal System.Windows.Controls.Image scripts_Copy;
        internal TextEditor Avalon;
        internal Border settings_border;
        internal System.Windows.Controls.CheckBox KrnlCheck;
        internal System.Windows.Controls.CheckBox WRDCHECK;
        internal System.Windows.Controls.Button wokring1;
        internal System.Windows.Controls.CheckBox Anticheck;
        internal System.Windows.Controls.CheckBox nokey_check;
        internal System.Windows.Controls.Button wokring1_Copy1;
        internal System.Windows.Controls.Button wokring1_Copy2;
        internal System.Windows.Controls.CheckBox removescriptboxcheck;
        internal System.Windows.Controls.Button working3;
        internal System.Windows.Controls.CheckBox debuginfocheck;
        internal System.Windows.Controls.Button working3_Copy;
        internal System.Windows.Controls.CheckBox fpsunlockercheck;
        internal System.Windows.Controls.Button working3_Copy1;
        internal System.Windows.Controls.CheckBox rblxfixercheck;
        internal System.Windows.Controls.Button working3_Copy2;
        internal System.Windows.Controls.Button discord;
        internal System.Windows.Controls.Button support;
        internal System.Windows.Controls.CheckBox removescriptboxcheck1;
        internal System.Windows.Controls.Button working1;
        internal System.Windows.Controls.Button execute;
        internal System.Windows.Controls.Button clear;
        internal System.Windows.Controls.Button open;
        internal System.Windows.Controls.Button save;
        internal System.Windows.Controls.Button save_Copy;
        internal System.Windows.Controls.Button save_Copy1;
        internal System.Windows.Controls.Button save_Copy2;
        internal Border borderscript;
        internal Grid script_hub_border;
        internal System.Windows.Controls.Button arsenal;
        internal System.Windows.Controls.Button bloxfruit;
        internal System.Windows.Controls.Button bloxburg;
        internal System.Windows.Controls.Button royalhigh;
        internal System.Windows.Controls.Button brookhaven;
        internal System.Windows.Controls.Button adoptme;
        internal System.Windows.Controls.Button bedwars;
        internal System.Windows.Controls.Button plsdonate;
        internal System.Windows.Controls.Button shindo_life_2;
        internal System.Windows.Controls.Button doors;
        internal Border settings_border_Copy;
        internal System.Windows.Controls.Button enablewhite;
        internal System.Windows.Controls.Button enablewhite3;
        internal System.Windows.Controls.CheckBox check1;
        private bool _contentLoaded;

        public MainWindow() => this.InitializeComponent();

        private static extern int ShowWindow(int hwnd, int nCmdShow);

        private void MainBorder_Loaded(

        object sender, RoutedEventArgs e)
        {
            this.Avalon.SyntaxHighlighting = HighlightingLoader.Load((XmlReader)new XmlTextReader((Stream)System.IO.File.OpenRead("./bin/lua.xshd")), (IHighlightingDefinitionReferenceResolver)HighlightingManager.Instance);
            this.List.Items.Clear();
            foreach (FileSystemInfo file in new DirectoryInfo("./Scripts").GetFiles("*.txt"))
                this.List.Items.Add((object)file.Name);
            foreach (FileSystemInfo file in new DirectoryInfo("./Scripts").GetFiles("*.lua"))
                this.List.Items.Add((object)file.Name);
        }

        private void scripts_Copy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.execute.Visibility = Visibility.Hidden;
            this.clear.Visibility = Visibility.Hidden;
            this.open.Visibility = Visibility.Hidden;
            this.save.Visibility = Visibility.Hidden;
            this.settings_border.Margin = new Thickness(56.0, 42.0, 10.0, 10.0);
            this.borderscript.Margin = new Thickness(680.0, 47.0, -614.0, 5.0);
            this.settings_border_Copy.Margin = new Thickness(680.0, 47.0, -614.0, 5.0);
        }

        private void home_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.execute.Visibility = Visibility.Visible;
            this.clear.Visibility = Visibility.Visible;
            this.open.Visibility = Visibility.Visible;
            this.save.Visibility = Visibility.Visible;
            this.settings_border.Margin = new Thickness(680.0, 47.0, -614.0, 5.0);
            this.borderscript.Margin = new Thickness(680.0, 47.0, -614.0, 5.0);
            this.settings_border_Copy.Margin = new Thickness(680.0, 47.0, -614.0, 5.0);
        }

        private void scripts_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.execute.Visibility = Visibility.Hidden;
            this.clear.Visibility = Visibility.Hidden;
            this.open.Visibility = Visibility.Hidden;
            this.save.Visibility = Visibility.Hidden;
            this.settings_border.Margin = new Thickness(680.0, 47.0, -614.0, 5.0);
            this.borderscript.Margin = new Thickness(56.0, 42.0, 10.0, 10.0);
            this.settings_border_Copy.Margin = new Thickness(680.0, 47.0, -614.0, 5.0);
        }

        private void Anticheck_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void Anticheck_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked = this.Anticheck.IsChecked;
            bool flag = true;
            if (isChecked.GetValueOrDefault() == flag & isChecked.HasValue)
                this.Avalon.Visibility = Visibility.Hidden;
            else
                this.Avalon.Visibility = Visibility.Visible;
        }

        private void nokey_check_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked = this.nokey_check.IsChecked;
            bool flag = true;
            if (!(isChecked.GetValueOrDefault() == flag & isChecked.HasValue))
                return;
            Process.Start(new ProcessStartInfo()
            {
                FileName = "https://www.elytrahacks.com/premium",
                UseShellExecute = true
            });
        }

        private void removescriptboxcheck_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked = this.removescriptboxcheck.IsChecked;
            bool flag = true;
            if (isChecked.GetValueOrDefault() == flag & isChecked.HasValue)
            {
                this.List.Visibility = Visibility.Hidden;
                this.Avalon.Margin = new Thickness(56.0, 42.0, 10.0, 5.0);
            }
            else
            {
                this.List.Visibility = Visibility.Visible;
                this.Avalon.Margin = new Thickness(56.0, 42.0, 124.0, 5.0);
            }
        }

        public static void sendDisWebhook(string URL, string json)
        {
            WebRequest webRequest = WebRequest.Create(URL);
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream()))
                streamWriter.Write(json);
            webRequest.GetResponse();
        }

        private void debuginfocheck_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked = this.debuginfocheck.IsChecked;
            bool flag = true;
            if (!(isChecked.GetValueOrDefault() == flag & isChecked.HasValue))
                return;
            new DiscordMessage().SetUsername("KalioV2").SetAvatar("https://cdn.discordapp.com/attachments/1023005833568718891/1025410000975319081/big.png").AddEmbed().SetTimestamp(DateTime.Now).SetTitle("Some dumass is using debug mode").SetColor(this.discordColor).SetFooter("new debug mode user", "https://cdn.discordapp.com/attachments/1023005833568718891/1025410000975319081/big.png").Build().SendMessage("https://discord.com/api/webhooks/1025411733050892424/gud9GQKyVMEU_uv4e4p4Orau5yeEv-J8gu5fvDLn_gh1Ojdisy8PG5CTi0SKU7g_kQRr");
            DiscordMessage discordMessage = new DiscordMessage()
            {
                Content = "Kek",
                Embeds = new System.Collections.Generic.List<Embed>()
        {
          new Embed() { Description = "Kek" }
        }
            };
        }

        private void fpsunlockercheck_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked = this.fpsunlockercheck.IsChecked;
            bool flag = true;
            if (!(isChecked.GetValueOrDefault() == flag & isChecked.HasValue))
                return;
            Process.Start("./bin/rbxfpsunlocker.exe");
        }

        private void rblxfixercheck_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked = this.fpsunlockercheck.IsChecked;
            bool flag = true;
            if (!(isChecked.GetValueOrDefault() == flag & isChecked.HasValue))
                return;
            Process.Start("./bin/rblxfix.exe");
        }

        private void settingsworking__Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num = (int)System.Windows.Forms.MessageBox.Show("May Not Be Working For Some People!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void wokring1_Click(object sender, RoutedEventArgs e)
        {
            int num = (int)System.Windows.Forms.MessageBox.Show("Working!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void wokring1_Copy_Click(object sender, RoutedEventArgs e)
        {
            int num = (int)System.Windows.Forms.MessageBox.Show("May Not Be Working For Some People!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void wokring1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            int num = (int)System.Windows.Forms.MessageBox.Show("Working!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void working3_Click(object sender, RoutedEventArgs e)
        {
            int num = (int)System.Windows.Forms.MessageBox.Show("Working!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void working3_Copy_Click(object sender, RoutedEventArgs e)
        {
            int num = (int)System.Windows.Forms.MessageBox.Show("Working!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void working3_Copy1_Click(object sender, RoutedEventArgs e)
        {
            int num = (int)System.Windows.Forms.MessageBox.Show("Working!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void working3_Copy2_Click(object sender, RoutedEventArgs e)
        {
            int num = (int)System.Windows.Forms.MessageBox.Show("Working!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void enablewhite_Click(object sender, RoutedEventArgs e)
        {
            int num = (int)System.Windows.Forms.MessageBox.Show("*WARNING* THIS THEME DOES NOT WORK WELL ON SOME DEVICES!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.MainBorder.Background = (Brush)Brushes.White;
            this.settings_border.Background = (Brush)Brushes.White;
            this.settings_border_Copy.Background = (Brush)Brushes.White;
            this.Second.Background = (Brush)Brushes.White;
            this.borderscript.Background = (Brush)Brushes.White;
            this.first.Background = (Brush)Brushes.White;
            this.label1.Background = (Brush)Brushes.Black;
        }

        private void thmes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.execute.Visibility = Visibility.Hidden;
            this.clear.Visibility = Visibility.Hidden;
            this.open.Visibility = Visibility.Hidden;
            this.save.Visibility = Visibility.Hidden;
            this.settings_border.Margin = new Thickness(680.0, 47.0, -614.0, 5.0);
            this.settings_border_Copy.Margin = new Thickness(56.0, 42.0, 10.0, 10.0);
            this.borderscript.Margin = new Thickness(680.0, 47.0, -614.0, 5.0);
        }

        private void enable_2_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void settings_border_Copy_DpiChanged(object sender, System.Windows.DpiChangedEventArgs e)
        {
        }

        private void enablewhite_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void enablewhite3_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void enablewhite3_Click(object sender, RoutedEventArgs e)
        {
            this.MainBorder.Background = (Brush)Brushes.DarkGray;
            this.settings_border.Background = (Brush)Brushes.DarkGray;
            this.settings_border_Copy.Background = (Brush)Brushes.DarkGray;
            this.Second.Background = (Brush)Brushes.DarkGray;
            this.borderscript.Background = (Brush)Brushes.DarkGray;
            this.first.Background = (Brush)Brushes.DarkGray;
            this.label1.Background = (Brush)Brushes.White;
        }

        private void execute_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked1 = this.WRDCHECK.IsChecked;
            bool flag1 = true;
            if (isChecked1.GetValueOrDefault() == flag1 & isChecked1.HasValue)
            {
                this.wrdapi.SendLuaScript(this.Avalon.Text);
            }
            else
            {
                bool? isChecked2 = this.KrnlCheck.IsChecked;
                bool flag2 = true;
                if (isChecked2.GetValueOrDefault() == flag2 & isChecked2.HasValue)
                {
                    this.krnlapi.Execute(this.Avalon.Text);
                }
                else
                {
                    int num = (int)System.Windows.Forms.MessageBox.Show("Please Select And Attach A API!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e) => this.Avalon.Clear();

        private void arsenal_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked1 = this.WRDCHECK.IsChecked;
            bool flag1 = true;
            if (isChecked1.GetValueOrDefault() == flag1 & isChecked1.HasValue)
            {
                this.wrdapi.SendLuaScript(new WebClient().DownloadString("https://pastebin.com/raw/vZwx3y4m"));
            }
            else
            {
                bool? isChecked2 = this.KrnlCheck.IsChecked;
                bool flag2 = true;
                if (isChecked2.GetValueOrDefault() == flag2 & isChecked2.HasValue)
                {
                    this.krnlapi.Execute(new WebClient().DownloadString("https://pastebin.com/raw/vZwx3y4m"));
                }
                else
                {
                    int num = (int)System.Windows.Forms.MessageBox.Show("Please Select And Attach A API!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void bloxfruit_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked1 = this.WRDCHECK.IsChecked;
            bool flag1 = true;
            if (isChecked1.GetValueOrDefault() == flag1 & isChecked1.HasValue)
            {
                this.wrdapi.SendLuaScript(new WebClient().DownloadString("https://pastebin.com/raw/uuqKRr5X"));
            }
            else
            {
                bool? isChecked2 = this.KrnlCheck.IsChecked;
                bool flag2 = true;
                if (isChecked2.GetValueOrDefault() == flag2 & isChecked2.HasValue)
                {
                    this.krnlapi.Execute(new WebClient().DownloadString("https://pastebin.com/raw/uuqKRr5X"));
                }
                else
                {
                    int num = (int)System.Windows.Forms.MessageBox.Show("Please Select And Attach A API!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void bloxburg_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked1 = this.WRDCHECK.IsChecked;
            bool flag1 = true;
            if (isChecked1.GetValueOrDefault() == flag1 & isChecked1.HasValue)
            {
                this.wrdapi.SendLuaScript(new WebClient().DownloadString("https://pastebin.com/raw/AMP8dcpX"));
            }
            else
            {
                bool? isChecked2 = this.KrnlCheck.IsChecked;
                bool flag2 = true;
                if (isChecked2.GetValueOrDefault() == flag2 & isChecked2.HasValue)
                {
                    this.krnlapi.Execute(new WebClient().DownloadString("https://pastebin.com/raw/AMP8dcpX"));
                }
                else
                {
                    int num = (int)System.Windows.Forms.MessageBox.Show("Please Select And Attach A API!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void royalhigh_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked1 = this.WRDCHECK.IsChecked;
            bool flag1 = true;
            if (isChecked1.GetValueOrDefault() == flag1 & isChecked1.HasValue)
            {
                this.wrdapi.SendLuaScript(new WebClient().DownloadString("https://pastebin.com/raw/sqzNBV4c"));
            }
            else
            {
                bool? isChecked2 = this.KrnlCheck.IsChecked;
                bool flag2 = true;
                if (isChecked2.GetValueOrDefault() == flag2 & isChecked2.HasValue)
                {
                    this.krnlapi.Execute(new WebClient().DownloadString("https://pastebin.com/raw/sqzNBV4c"));
                }
                else
                {
                    int num = (int)System.Windows.Forms.MessageBox.Show("Please Select And Attach A API!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void brookhaven_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked1 = this.WRDCHECK.IsChecked;
            bool flag1 = true;
            if (isChecked1.GetValueOrDefault() == flag1 & isChecked1.HasValue)
            {
                this.wrdapi.SendLuaScript(new WebClient().DownloadString("https://pastebin.com/raw/51EX40DS"));
            }
            else
            {
                bool? isChecked2 = this.KrnlCheck.IsChecked;
                bool flag2 = true;
                if (isChecked2.GetValueOrDefault() == flag2 & isChecked2.HasValue)
                {
                    this.krnlapi.Execute(new WebClient().DownloadString("https://pastebin.com/raw/51EX40DS"));
                }
                else
                {
                    int num = (int)System.Windows.Forms.MessageBox.Show("Please Select And Attach A API!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void adoptme_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked1 = this.WRDCHECK.IsChecked;
            bool flag1 = true;
            if (isChecked1.GetValueOrDefault() == flag1 & isChecked1.HasValue)
            {
                this.wrdapi.SendLuaScript(new WebClient().DownloadString("https://pastebin.com/raw/b8L8iueS"));
            }
            else
            {
                bool? isChecked2 = this.KrnlCheck.IsChecked;
                bool flag2 = true;
                if (isChecked2.GetValueOrDefault() == flag2 & isChecked2.HasValue)
                {
                    this.krnlapi.Execute(new WebClient().DownloadString("https://pastebin.com/raw/b8L8iueS"));
                }
                else
                {
                    int num = (int)System.Windows.Forms.MessageBox.Show("Please Select And Attach A API!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void bedwars_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked1 = this.WRDCHECK.IsChecked;
            bool flag1 = true;
            if (isChecked1.GetValueOrDefault() == flag1 & isChecked1.HasValue)
            {
                this.wrdapi.SendLuaScript(new WebClient().DownloadString("https://pastebin.com/raw/4QSX6wdG"));
            }
            else
            {
                bool? isChecked2 = this.KrnlCheck.IsChecked;
                bool flag2 = true;
                if (isChecked2.GetValueOrDefault() == flag2 & isChecked2.HasValue)
                {
                    this.krnlapi.Execute(new WebClient().DownloadString("https://pastebin.com/raw/4QSX6wdG"));
                }
                else
                {
                    int num = (int)System.Windows.Forms.MessageBox.Show("Please Select And Attach A API!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void plsdonate_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked1 = this.WRDCHECK.IsChecked;
            bool flag1 = true;
            if (isChecked1.GetValueOrDefault() == flag1 & isChecked1.HasValue)
            {
                this.wrdapi.SendLuaScript(new WebClient().DownloadString("https://pastebin.com/raw/EA5numw0"));
            }
            else
            {
                bool? isChecked2 = this.KrnlCheck.IsChecked;
                bool flag2 = true;
                if (isChecked2.GetValueOrDefault() == flag2 & isChecked2.HasValue)
                {
                    this.krnlapi.Execute(new WebClient().DownloadString("https://pastebin.com/raw/EA5numw0"));
                }
                else
                {
                    int num = (int)System.Windows.Forms.MessageBox.Show("Please Select And Attach A API!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void shindo_life_2_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked1 = this.WRDCHECK.IsChecked;
            bool flag1 = true;
            if (isChecked1.GetValueOrDefault() == flag1 & isChecked1.HasValue)
            {
                this.wrdapi.SendLuaScript(new WebClient().DownloadString("https://pastebin.com/raw/291xbENd"));
            }
            else
            {
                bool? isChecked2 = this.KrnlCheck.IsChecked;
                bool flag2 = true;
                if (isChecked2.GetValueOrDefault() == flag2 & isChecked2.HasValue)
                {
                    this.krnlapi.Execute(new WebClient().DownloadString("https://pastebin.com/raw/291xbENd"));
                }
                else
                {
                    int num = (int)System.Windows.Forms.MessageBox.Show("Please Select And Attach A API!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void doors_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked1 = this.WRDCHECK.IsChecked;
            bool flag1 = true;
            if (isChecked1.GetValueOrDefault() == flag1 & isChecked1.HasValue)
            {
                this.wrdapi.SendLuaScript(new WebClient().DownloadString("https://pastebin.com/raw/eKhQkqB3"));
            }
            else
            {
                bool? isChecked2 = this.KrnlCheck.IsChecked;
                bool flag2 = true;
                if (isChecked2.GetValueOrDefault() == flag2 & isChecked2.HasValue)
                {
                    this.krnlapi.Execute(new WebClient().DownloadString("https://pastebin.com/raw/eKhQkqB3"));
                }
                else
                {
                    int num = (int)System.Windows.Forms.MessageBox.Show("Please Select And Attach A API!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.List.SelectedIndex == -1)
                return;
            this.Avalon.Text = System.IO.File.ReadAllText("scripts\\" + this.List.SelectedItem.ToString());
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            bool? nullable1 = openFileDialog.ShowDialog();
            openFileDialog.Filter = "Lua Scripts (*.lua)|*.lua|Txt Scripts (*.txt)|*.txt";
            openFileDialog.Title = "Save Scripts";
            bool? nullable2 = nullable1;
            bool flag = true;
            if (!(nullable2.GetValueOrDefault() == flag & nullable2.HasValue))
                return;
            this.Avalon.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            bool? nullable1 = saveFileDialog.ShowDialog();
            saveFileDialog.Filter = "Lua Scripts (*.lua)|*.lua|Txt Scripts (*.txt)|*.txt";
            saveFileDialog.Title = "Save Scripts";
            bool? nullable2 = nullable1;
            bool flag = true;
            if (!(nullable2.GetValueOrDefault() == flag & nullable2.HasValue))
                return;
            System.IO.File.WriteAllText(saveFileDialog.FileName, this.Avalon.Text);
        }

        private async void save_Copy2_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked = this.WRDCHECK.IsChecked;
            bool flag1 = true;
            if (isChecked.GetValueOrDefault() == flag1 & isChecked.HasValue)
            {
                Process.Start("./bin/Injector/kaliodll.exe");
                this.wrdapi.LaunchExploit();
                for (int i = 1; i <= 30; ++i)
                {
                    Process[] processRunning = Process.GetProcesses();
                    Process[] processArray1 = processRunning;
                    for (int index = 0; index < processArray1.Length; ++index)
                    {
                        Process pr = processArray1[index];
                        if (pr.ProcessName == "finj")
                        {
                            int hWnd = pr.MainWindowHandle.ToInt32();
                            MainWindow.ShowWindow(hWnd, 0);
                        }
                        pr = (Process)null;
                    }
                    processArray1 = (Process[])null;
                    Process[] processRunningdd = Process.GetProcesses();
                    Process[] processArray2 = processRunningdd;
                    for (int index = 0; index < processArray2.Length; ++index)
                    {
                        Process prdd = processArray2[index];
                        if (prdd.MainWindowTitle == "WRD-API")
                        {
                            int hWnddd = prdd.MainWindowHandle.ToInt32();
                            MainWindow.ShowWindow(hWnddd, 0);
                        }
                        prdd = (Process)null;
                    }
                    processArray2 = (Process[])null;
                    processRunning = (Process[])null;
                    processRunningdd = (Process[])null;
                }
            }
            else
            {
                isChecked = this.KrnlCheck.IsChecked;
                bool flag2 = true;
                if (isChecked.GetValueOrDefault() == flag2 & isChecked.HasValue)
                {
                    int num1 = (int)this.krnlapi.Inject();
                }
                else
                {
                    int num2 = (int)System.Windows.Forms.MessageBox.Show("Please Select A API!", "KalioV3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void save_Copy_Click(object sender, RoutedEventArgs e) => System.Windows.Application.Current.Shutdown();

        private void save_Copy1_Click(object sender, RoutedEventArgs e) => this.WindowState = WindowState.Minimized;

        private void discord_Click(object sender, RoutedEventArgs e) => Process.Start(new ProcessStartInfo()
        {
            FileName = "https://discord.gg/9RYj3ns6X9",
            UseShellExecute = true
        });

        private void support_Click(object sender, RoutedEventArgs e) => Process.Start(new ProcessStartInfo()
        {
            FileName = "https://discord.gg/9RYj3ns6X9",
            UseShellExecute = true
        });

        private void Button_Click_1(object sender, RoutedEventArgs e) => Process.Start(new ProcessStartInfo()
        {
            FileName = "https://discord.gg/9RYj3ns6X9",
            UseShellExecute = true
        });

        private void first_MouseDown(object sender, MouseButtonEventArgs e) => this.DragMove();

        [DebuggerNonUserCode]
        [GeneratedCode("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent()
        {
            if (this._contentLoaded)
                return;
            this._contentLoaded = true;
            System.Windows.Application.LoadComponent((object)this, new Uri("/KalioWPFV3;component/mainwindow.xaml", UriKind.Relative));
        }

        [DebuggerNonUserCode]
        [GeneratedCode("PresentationBuildTasks", "6.0.9.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId,

        object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.MainBorder = (Border)target;
                    this.MainBorder.Loaded += new RoutedEventHandler(this.MainBorder_Loaded);
                    break;
                case 2:
                    this.List = (System.Windows.Controls.ListBox)target;
                    this.List.SelectionChanged += new SelectionChangedEventHandler(this.List_SelectionChanged);
                    break;
                case 3:
                    this.first = (Border)target;
                    this.first.MouseDown += new MouseButtonEventHandler(this.first_MouseDown);
                    break;
                case 4:
                    this.label1 = (System.Windows.Controls.Label)target;
                    break;
                case 5:
                    this.Second = (Border)target;
                    break;
                case 6:
                    this.home = (System.Windows.Controls.Image)target;
                    this.home.MouseDown += new MouseButtonEventHandler(this.home_MouseDown);
                    break;
                case 7:
                    this.scripts = (System.Windows.Controls.Image)target;
                    this.scripts.MouseDown += new MouseButtonEventHandler(this.scripts_MouseDown);
                    break;
                case 8:
                    this.scripts_Copy = (System.Windows.Controls.Image)target;
                    this.scripts_Copy.MouseDown += new MouseButtonEventHandler(this.scripts_Copy_MouseDown);
                    break;
                case 9:
                    this.Avalon = (TextEditor)target;
                    break;
                case 10:
                    this.settings_border = (Border)target;
                    break;
                case 11:
                    this.KrnlCheck = (System.Windows.Controls.CheckBox)target;
                    break;
                case 12:
                    ((System.Windows.Controls.Primitives.ButtonBase)target).Click += new RoutedEventHandler(this.Button_Click);
                    break;
                case 13:
                    this.WRDCHECK = (System.Windows.Controls.CheckBox)target;
                    break;
                case 14:
                    this.wokring1 = (System.Windows.Controls.Button)target;
                    this.wokring1.Click += new RoutedEventHandler(this.wokring1_Click);
                    break;
                case 15:
                    this.Anticheck = (System.Windows.Controls.CheckBox)target;
                    this.Anticheck.Checked += new RoutedEventHandler(this.Anticheck_Checked);
                    this.Anticheck.Click += new RoutedEventHandler(this.Anticheck_Click);
                    break;
                case 16:
                    ((System.Windows.Controls.Primitives.ButtonBase)target).Click += new RoutedEventHandler(this.Button_Click);
                    break;
                case 17:
                    this.nokey_check = (System.Windows.Controls.CheckBox)target;
                    this.nokey_check.Click += new RoutedEventHandler(this.nokey_check_Click);
                    break;
                case 18:
                    this.wokring1_Copy1 = (System.Windows.Controls.Button)target;
                    this.wokring1_Copy1.Click += new RoutedEventHandler(this.wokring1_Copy1_Click);
                    break;
                case 19:
                    this.wokring1_Copy2 = (System.Windows.Controls.Button)target;
                    this.wokring1_Copy2.Click += new RoutedEventHandler(this.wokring1_Copy1_Click);
                    break;
                case 20:
                    this.removescriptboxcheck = (System.Windows.Controls.CheckBox)target;
                    this.removescriptboxcheck.Click += new RoutedEventHandler(this.removescriptboxcheck_Click);
                    break;
                case 21:
                    this.working3 = (System.Windows.Controls.Button)target;
                    this.working3.Click += new RoutedEventHandler(this.working3_Click);
                    break;
                case 22:
                    this.debuginfocheck = (System.Windows.Controls.CheckBox)target;
                    this.debuginfocheck.Click += new RoutedEventHandler(this.debuginfocheck_Click);
                    break;
                case 23:
                    this.working3_Copy = (System.Windows.Controls.Button)target;
                    this.working3_Copy.Click += new RoutedEventHandler(this.working3_Copy_Click);
                    break;
                case 24:
                    this.fpsunlockercheck = (System.Windows.Controls.CheckBox)target;
                    this.fpsunlockercheck.Click += new RoutedEventHandler(this.fpsunlockercheck_Click);
                    break;
                case 25:
                    this.working3_Copy1 = (System.Windows.Controls.Button)target;
                    this.working3_Copy1.Click += new RoutedEventHandler(this.working3_Copy1_Click);
                    break;
                case 26:
                    this.rblxfixercheck = (System.Windows.Controls.CheckBox)target;
                    this.rblxfixercheck.Click += new RoutedEventHandler(this.rblxfixercheck_Click);
                    break;
                case 27:
                    this.working3_Copy2 = (System.Windows.Controls.Button)target;
                    this.working3_Copy2.Click += new RoutedEventHandler(this.working3_Copy2_Click);
                    break;
                case 28:
                    this.discord = (System.Windows.Controls.Button)target;
                    this.discord.Click += new RoutedEventHandler(this.discord_Click);
                    break;
                case 29:
                    this.support = (System.Windows.Controls.Button)target;
                    this.support.Click += new RoutedEventHandler(this.support_Click);
                    break;
                case 30:
                    this.removescriptboxcheck1 = (System.Windows.Controls.CheckBox)target;
                    this.removescriptboxcheck1.Click += new RoutedEventHandler(this.removescriptboxcheck_Click);
                    break;
                case 31:
                    this.working1 = (System.Windows.Controls.Button)target;
                    this.working1.Click += new RoutedEventHandler(this.working3_Click);
                    break;
                case 32:
                    this.execute = (System.Windows.Controls.Button)target;
                    this.execute.Click += new RoutedEventHandler(this.execute_Click);
                    break;
                case 33:
                    this.clear = (System.Windows.Controls.Button)target;
                    this.clear.Click += new RoutedEventHandler(this.clear_Click);
                    break;
                case 34:
                    this.open = (System.Windows.Controls.Button)target;
                    this.open.Click += new RoutedEventHandler(this.open_Click);
                    break;
                case 35:
                    this.save = (System.Windows.Controls.Button)target;
                    this.save.Click += new RoutedEventHandler(this.save_Click);
                    break;
                case 36:
                    this.save_Copy = (System.Windows.Controls.Button)target;
                    this.save_Copy.Click += new RoutedEventHandler(this.save_Copy_Click);
                    break;
                case 37:
                    this.save_Copy1 = (System.Windows.Controls.Button)target;
                    this.save_Copy1.Click += new RoutedEventHandler(this.save_Copy1_Click);
                    break;
                case 38:
                    this.save_Copy2 = (System.Windows.Controls.Button)target;
                    this.save_Copy2.Click += new RoutedEventHandler(this.save_Copy2_Click);
                    break;
                case 39:
                    this.borderscript = (Border)target;
                    break;
                case 40:
                    this.script_hub_border = (Grid)target;
                    break;
                case 41:
                    this.arsenal = (System.Windows.Controls.Button)target;
                    this.arsenal.Click += new RoutedEventHandler(this.arsenal_Click);
                    break;
                case 42:
                    this.bloxfruit = (System.Windows.Controls.Button)target;
                    this.bloxfruit.Click += new RoutedEventHandler(this.bloxfruit_Click);
                    break;
                case 43:
                    this.bloxburg = (System.Windows.Controls.Button)target;
                    this.bloxburg.Click += new RoutedEventHandler(this.bloxburg_Click);
                    break;
                case 44:
                    this.royalhigh = (System.Windows.Controls.Button)target;
                    this.royalhigh.Click += new RoutedEventHandler(this.royalhigh_Click);
                    break;
                case 45:
                    this.brookhaven = (System.Windows.Controls.Button)target;
                    this.brookhaven.Click += new RoutedEventHandler(this.brookhaven_Click);
                    break;
                case 46:
                    this.adoptme = (System.Windows.Controls.Button)target;
                    this.adoptme.Click += new RoutedEventHandler(this.adoptme_Click);
                    break;
                case 47:
                    this.bedwars = (System.Windows.Controls.Button)target;
                    this.bedwars.Click += new RoutedEventHandler(this.bedwars_Click);
                    break;
                case 48:
                    this.plsdonate = (System.Windows.Controls.Button)target;
                    this.plsdonate.Click += new RoutedEventHandler(this.plsdonate_Click);
                    break;
                case 49:
                    this.shindo_life_2 = (System.Windows.Controls.Button)target;
                    this.shindo_life_2.Click += new RoutedEventHandler(this.shindo_life_2_Click);
                    break;
                case 50:
                    this.doors = (System.Windows.Controls.Button)target;
                    this.doors.Click += new RoutedEventHandler(this.doors_Click);
                    break;
                case 51:
                    ((System.Windows.Controls.Primitives.ButtonBase)target).Click += new RoutedEventHandler(this.Button_Click_1);
                    break;
                case 52:
                    this.settings_border_Copy = (Border)target;
                    break;
                case 53:
                    this.enablewhite = (System.Windows.Controls.Button)target;
                    this.enablewhite.Click += new RoutedEventHandler(this.enablewhite_Click);
                    this.enablewhite.MouseDown += new MouseButtonEventHandler(this.enablewhite_MouseDown);
                    break;
                case 54:
                    this.enablewhite3 = (System.Windows.Controls.Button)target;
                    this.enablewhite3.Click += new RoutedEventHandler(this.enablewhite3_Click);
                    this.enablewhite3.MouseDown += new MouseButtonEventHandler(this.enablewhite3_MouseDown);
                    break;
                case 55:
                    this.check1 = (System.Windows.Controls.CheckBox)target;
                    break;
                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}
