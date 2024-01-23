using mp3scrUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mp3scrUI
{
    public partial class mp3scrUI : Form
    {
        string configFilePath = string.Empty;
        bool somethingChanged = false;

        /// <summary>
        /// Constructor
        /// </summary>
        public mp3scrUI()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Settings.Default.InitialDirectory;
                openFileDialog.Filter = "config files (*.config)|*.config|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                try
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        configFilePath = openFileDialog.FileName;
                    }
                    else
                    {
                        // Canceled
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    Application.Exit();
                }
            }

            configFileNameTextBox.Text = configFilePath;
            Application.DoEvents();

            XmlDocument configDocument = new XmlDocument();
            configDocument.Load(configFilePath);
            Application.DoEvents();

            RefreshGrid(configDocument);

            // Nothing has changed, yet.
            somethingChanged = false;
        }

        /// <summary>
        /// Fill in the grid when a file is opened.
        /// </summary>
        private void RefreshGrid(XmlDocument configDocument)
        {
            scrapesDataGridView.Rows.Clear();
            string nodeName = string.Empty;
            int gridRowIndex = 0;

            // Get all the add nodes under configuration
            XmlNode configurationAddNodes = configDocument.SelectSingleNode("configuration/appSettings");

            // Show the value of testIndex 
            nodeName = "testIndex";
            XmlNode configNode = configurationAddNodes.SelectSingleNode("add[@key='" + nodeName + "']");
            XmlNode configNodeValueNode = configNode.SelectSingleNode("@value");
            testIndexTextBox.Text = configNodeValueNode.InnerXml;

            // Cursor while loading
            this.Cursor = Cursors.WaitCursor;
            scrapesDataGridView.Cursor = Cursors.WaitCursor;
            // Hide the grid while loading to make it more faster.
            scrapesDataGridView.Visible = false;

            try
            {
                for (int index = 1; index <= 9999; index++)
                {
                    try
                    {
                        string indexString = index.ToString("d4");

                        // Enabled_
                        nodeName = "enabled" + indexString;
                        configNode = configurationAddNodes.SelectSingleNode("add[@key='" + nodeName + "']");
                        // If there is no Enabled node for the index, then continue to the next index.
                        if (configNode == null)
                        {
                            continue;
                        }

                        // Add a row to the grid
                        gridRowIndex = scrapesDataGridView.Rows.Add();

                        configNodeValueNode = configNode.SelectSingleNode("@value");
                        scrapesDataGridView.Rows[gridRowIndex].Cells["Enabled_"].Value = bool.Parse(configNodeValueNode.InnerXml);

                        // Index
                        scrapesDataGridView.Rows[gridRowIndex].Cells["Index"].Value = indexString;

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "Url", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "UrlPrefix", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "DestBase", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "DestFolderName", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "ExistingFeedFolder", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "GuidPrefix", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "Mp3Filter", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "IndirectFilter", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "Indirect", indexString,
                            configurationAddNodes, gridRowIndex, typeof(bool));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "ChannelTitle", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "ChannelNotes", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "SortDescending", indexString,
                            configurationAddNodes, gridRowIndex, typeof(bool));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "RetainOrphans", indexString,
                            configurationAddNodes, gridRowIndex, typeof(bool));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "StripBaseName", indexString,
                            configurationAddNodes, gridRowIndex, typeof(bool));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "PrependRelative", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "RefreshDays", indexString,
                            configurationAddNodes, gridRowIndex, typeof(int));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "FtpPath", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "FtpUserName", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "FtpPassword", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "PermissionRevoked", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "AllowHttps", indexString,
                            configurationAddNodes, gridRowIndex, typeof(bool));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "Wraparound", indexString,
                            configurationAddNodes, gridRowIndex, typeof(bool));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "MaxWebRequests", indexString,
                            configurationAddNodes, gridRowIndex, typeof(int));

                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "MaintenanceA", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));
                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "MaintenanceB", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));
                        RefreshCellOfRowOfGrid(scrapesDataGridView.Rows[gridRowIndex], "MaintenanceC", indexString,
                            configurationAddNodes, gridRowIndex, typeof(string));

                        scrapesDataGridView.FirstDisplayedScrollingRowIndex = gridRowIndex;
                        Application.DoEvents();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + Environment.NewLine +
                            "Continuing to next item.", "Error");
                    }
                }
            }
            catch { }
            finally
            {
                // Finally ensures the visibility and cursors are reset.
                scrapesDataGridView.Visible = true;
                scrapesDataGridView.Cursor = Cursors.Default;
                this.Cursor = Cursors.Default;
            }

            // After loading a file, the first (Enabled) textbox appears unchecked even if the config says
            // it is enabled. Force some selections and deselections to get the first row to appear correctly.
            if (scrapesDataGridView.Rows.Count > 0)
            {
                scrapesDataGridView.Rows[0].Selected = true;
                scrapesDataGridView.FirstDisplayedScrollingRowIndex = 0;
                scrapesDataGridView.Rows[0].Cells["Url"].Selected = true;
                scrapesDataGridView.Rows[0].Cells["Url"].Selected = false;
            }

            // Cursor after loading
            scrapesDataGridView.Cursor = Cursors.Arrow;
        }

        /// <summary>
        /// Fill in a cell of the supplied row with the value from the current config file.
        /// </summary>
        /// <param name="row">The row in the grid</param>
        /// <param name="colName">The column of the row</param>
        /// <param name="indexString">The configuration items's index</param>
        /// <param name="configurationAddNodes">The nodes from the config file</param>
        /// <param name="gridRowIndex">The index assigned when the row is created</param>
        /// <param name="colType">The datatype of the column, so that the string value can be parsed.</param>
        private void RefreshCellOfRowOfGrid(DataGridViewRow row, string colName, string indexString,
            XmlNode configurationAddNodes, int gridRowIndex, Type colType)
        {
            try
            {
                if ((row == null) || string.IsNullOrEmpty(colName) || string.IsNullOrEmpty(indexString) ||
                    (configurationAddNodes == null) || (gridRowIndex < 0))
                {
                    throw new ArgumentException("Bad argument to RefreshCellOfRowOfGrid.");
                }
                string colNameToLower = char.ToLower(colName[0]) + colName.Substring(1);
                string nodeName = colNameToLower + indexString;
                XmlNode configNode = configurationAddNodes.SelectSingleNode("add[@key='" + nodeName + "']");
                XmlNode configNodeValueNode = configNode.SelectSingleNode("@value");

                //? configNodeValueNode.InnerXml
                //"audio_url:\"https:\\u002F\\u002Fdownloads.pod.co\\u002F578b895c-229c-41b5-87bd-c748adc84fd7\\u002F"
                //? configNodeValueNode.OuterXml

                // Can't use InnerXml because it changes &quot; to double-quotes.
                // OuterXml will look something like:
                //"value=\"audio_url:&quot;https""
                string myValue = configNodeValueNode.OuterXml;
                // Strip off value=\"
                myValue = myValue.Replace("value=\"", "");
                // Remove the trailing double-quote
                myValue = myValue.Substring(0, myValue.Length - 1);
                // The result will be in this example:
                // "audio_url:&quot;https"
                if (colType == typeof(string))
                {
                    row.Cells[colName].Value = myValue;
                }
                else if (colType == typeof(int))
                {
                    row.Cells[colName].Value = int.Parse(myValue);
                }
                else if (colType == typeof(bool))
                {
                    row.Cells[colName].Value = bool.Parse(myValue);
                }
                else
                {
                    row.Cells[colName].Value = "bad type";
                }
            }
            catch
            {
                if (string.IsNullOrEmpty(colName))
                {
                    colName = "empty colName";
                }
                else
                {
                    row.Cells[colName].Value = "bad type";
                }
                indexString = (string.IsNullOrEmpty(indexString) ? "empty indexString" : indexString);
                MessageBox.Show("Error parsing " + colName + " in row " + indexString, "Error");
            }
        }

        /// <summary>
        /// The user clicked the Save As... menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder configSb = new StringBuilder();
            configSb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            configSb.AppendLine("<!-- Copyright © " + DateTime.Now.Year.ToString("d4") + ", Gary Gocek, https://gary.gocek.org, gary@gocek.org -->");
            configSb.AppendLine("<configuration>");
            configSb.AppendLine("<startup>");
            configSb.AppendLine("<supportedRuntime version=\"v4.0\" sku=\".NETFramework,Version=v4.8\"/>");
            configSb.AppendLine("</startup>");
            configSb.AppendLine("<appSettings>");

            configSb.AppendLine("<add key=\"testIndex\" value=\"" + testIndexTextBox.Text + "\" />");

            ScrapeItem si = null;
            foreach (DataGridViewRow dgvr in scrapesDataGridView.Rows)
            {
                if (dgvr.IsNewRow)
                    continue; // Avoid trying to save the bottom row where a new row is added.
                si = new ScrapeItem();
                si = si.Load(dgvr);

                configSb.AppendLine("<!-- -->"); // Start every scrape section with a comment.
                configSb.AppendLine("<add key=\"enabled" + si.Index.ToString() + "\" value=\"" +
                    si.Enabled.ToString().ToLower() + "\" />");
                configSb.AppendLine("<add key=\"url" + si.Index.ToString() + "\" value=\"" +
                    si.Url + "\" />");
                configSb.AppendLine("<add key=\"urlPrefix" + si.Index.ToString() + "\" value=\"" +
                    si.UrlPrefix + "\" />");
                configSb.AppendLine("<add key=\"destBase" + si.Index.ToString() + "\" value=\"" +
                    si.DestBase + "\" />");
                configSb.AppendLine("<add key=\"destFolderName" + si.Index.ToString() + "\" value=\"" +
                    si.DestFolderName + "\" />");
                configSb.AppendLine("<add key=\"existingFeedFolder" + si.Index.ToString() + "\" value=\"" +
                    si.ExistingFeedFolder + "\" />");
                configSb.AppendLine("<add key=\"guidPrefix" + si.Index.ToString() + "\" value=\"" +
                    si.GuidPrefix + "\" />");
                configSb.AppendLine("<add key=\"mp3Filter" + si.Index.ToString() + "\" value=\"" +
                    si.Mp3Filter + "\" />");
                configSb.AppendLine("<add key=\"indirectFilter" + si.Index.ToString() + "\" value=\"" +
                    si.IndirectFilter + "\" />");
                configSb.AppendLine("<add key=\"indirect" + si.Index.ToString() + "\" value=\"" +
                    si.Indirect.ToString().ToLower() + "\" />");
                configSb.AppendLine("<add key=\"channelTitle" + si.Index.ToString() + "\" value=\"" +
                    si.ChannelTitle + "\" />");
                configSb.AppendLine("<add key=\"channelNotes" + si.Index.ToString() + "\" value=\"" +
                    si.ChannelNotes + "\" />");
                configSb.AppendLine("<add key=\"sortDescending" + si.Index.ToString() + "\" value=\"" +
                    si.SortDescending.ToString().ToLower() + "\" />");
                configSb.AppendLine("<add key=\"retainOrphans" + si.Index.ToString() + "\" value=\"" +
                    si.RetainOrphans.ToString().ToLower() + "\" />");
                configSb.AppendLine("<add key=\"stripBaseName" + si.Index.ToString() + "\" value=\"" +
                    si.StripBaseName.ToString().ToLower() + "\" />");
                configSb.AppendLine("<add key=\"prependRelative" + si.Index.ToString() + "\" value=\"" +
                    si.PrependRelative + "\" />");
                configSb.AppendLine("<add key=\"refreshDays" + si.Index.ToString() + "\" value=\"" +
                    si.RefreshDays.ToString() + "\" />");
                configSb.AppendLine("<add key=\"ftpPath" + si.Index.ToString() + "\" value=\"" +
                    si.FtpPath + "\" />");
                configSb.AppendLine("<add key=\"ftpUserName" + si.Index.ToString() + "\" value=\"" +
                    si.FtpUserName + "\" />");
                configSb.AppendLine("<add key=\"ftpPassword" + si.Index.ToString() + "\" value=\"" +
                    si.FtpPassword + "\" />");
                configSb.AppendLine("<add key=\"permissionRevoked" + si.Index.ToString() + "\" value=\"" +
                    si.PermissionRevoked + "\" />");
                configSb.AppendLine("<add key=\"allowHttps" + si.Index.ToString() + "\" value=\"" +
                    si.AllowHttps.ToString().ToLower() + "\" />");
                configSb.AppendLine("<add key=\"wraparound" + si.Index.ToString() + "\" value=\"" +
                    si.Wraparound.ToString().ToLower() + "\" />");
                configSb.AppendLine("<add key=\"maxWebRequests" + si.Index.ToString() + "\" value=\"" +
                    si.MaxWebRequests.ToString() + "\" />");
                configSb.AppendLine("<add key=\"maintenanceA" + si.Index.ToString() + "\" value=\"" +
                    si.MaintenanceA + "\" />");
                configSb.AppendLine("<add key=\"maintenanceB" + si.Index.ToString() + "\" value=\"" +
                    si.MaintenanceB + "\" />");
                configSb.AppendLine("<add key=\"maintenanceC" + si.Index.ToString() + "\" value=\"" +
                    si.MaintenanceC + "\" />");
                // No need to put a blank line at the end of each section, since each section
                // starts with an obvious comment.
            }

            // FInal section after all the scrape sections.
            configSb.AppendLine("<!-- -->"); // Start every scrape section with a comment.
            configSb.AppendLine("<add key=\"ClientSettingsProvider.ServiceUri\" value=\"\" />");
            configSb.AppendLine("</appSettings>");
            configSb.AppendLine("<system.web>");
            configSb.AppendLine("<membership defaultProvider=\"ClientAuthenticationMembershipProvider\">");
            configSb.AppendLine("<providers>");
            configSb.AppendLine("<add name=\"ClientAuthenticationMembershipProvider\" type=\"System.Web.ClientServices.Providers.ClientFormsAuthenticationMembershipProvider, System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\" serviceUri=\"\" />");
            configSb.AppendLine("</providers>");
            configSb.AppendLine("</membership>");
            configSb.AppendLine("<roleManager defaultProvider=\"ClientRoleProvider\" enabled=\"true\">");
            configSb.AppendLine("<providers>");
            configSb.AppendLine("<add name=\"ClientRoleProvider\" type=\"System.Web.ClientServices.Providers.ClientRoleProvider, System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\" serviceUri=\"\" cacheTimeout=\"86400\" />");
            configSb.AppendLine("</providers>");
            configSb.AppendLine("</roleManager>");
            configSb.AppendLine("</system.web>");
            configSb.AppendLine("</configuration>");
            somethingChanged = false;

            // Allow the user to specify a file and save it.
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                try
                {
                    saveFileDialog.InitialDirectory = Path.GetDirectoryName(configFilePath);
                    saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 2;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Can use dialog.FileName
                        using (System.IO.StreamWriter streamWr = new System.IO.StreamWriter(saveFileDialog.FileName.ToString()))
                        {
                            streamWr.WriteLine(configSb.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error while saving");
                    Application.Exit();
                }

                try
                {
                    // Re-open the just-saved file as the open file
                    configFilePath = saveFileDialog.FileName;
                    configFileNameTextBox.Text = configFilePath;
                    Application.DoEvents();
                    XmlDocument configDocument = new XmlDocument();
                    configDocument.Load(configFilePath);
                    Application.DoEvents();
                    RefreshGrid(configDocument);
                    // Nothing has changed, yet.
                    somethingChanged = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error while reloading");
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// Save the window location and size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mp3scrUI_Load(object sender, EventArgs e)
        {
            // Save the window location and size
            //base.OnSourceInitialized(e); // this is from the web page, not sure if this is needed
            WindowPlacement.SetPlacement(this.Handle, Settings.Default.MainWindowPlacement);

            // Set the width of the leftmost column
            scrapesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            scrapesDataGridView.RowHeadersWidth = 30;

            // Tool tips
            System.Windows.Forms.ToolTip myTToolTip = new System.Windows.Forms.ToolTip();
            myTToolTip.ToolTipTitle = "Test index";
            myTToolTip.InitialDelay = 0;
            myTToolTip.SetToolTip(testIndexTextBox, "Blank or the 4-digit index of the item to scrape.");

            // Tool tips
            System.Windows.Forms.ToolTip mySToolTip = new System.Windows.Forms.ToolTip();
            mySToolTip.ToolTipTitle = "Search";
            mySToolTip.InitialDelay = 0;
            mySToolTip.SetToolTip(searchTextBox, "Type search text, ENTER to start/restart search.");

            // Nothing has changed, yet.
            somethingChanged = false;
        }

        /// <summary>
        /// Exit via the menu button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (somethingChanged)
            {
                DialogResult dRes = MessageBox.Show("Something changed. Click OK to exit." + Environment.NewLine +
                    "Click Cancel to be able to save the changes.",
                    "Unsaved changes!",
                    MessageBoxButtons.OKCancel);
                if (dRes == DialogResult.Cancel)
                {
                    return;
                }
            }
            // Set somethingChanged to false so that FormClosing doesn't ask again.
            somethingChanged = false;
            Application.Exit();
        }

        /// <summary>
        /// Save the window location and size. This method may be called via the menu or the X button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mp3scrUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.MainWindowPlacement = WindowPlacement.GetPlacement(this.Handle);
            Settings.Default.Save();

            if (somethingChanged)
            {
                DialogResult dRes = MessageBox.Show("Something changed. Click OK to exit." + Environment.NewLine +
                    "Click Cancel to be able to save the changes.",
                    "Unsaved changes!",
                    MessageBoxButtons.OKCancel);
                if (dRes == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Allow only integers for the test index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(testIndexTextBox.Text, "[^0-9]"))
            {
                testIndexTextBox.Text = testIndexTextBox.Text.Remove(testIndexTextBox.Text.Length - 1);
                somethingChanged = true;
            }
        }

        /// <summary>
        /// Set the default cell values when a new row is created in the grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scrapesDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Index"].Value = Settings.Default.DefaultIndex;
            e.Row.Cells["Enabled_"].Value = Settings.Default.DefaultEnabled;
            e.Row.Cells["Url"].Value = Settings.Default.DefaultUrl;
            e.Row.Cells["UrlPrefix"].Value = Settings.Default.DefaultUrlPrefix;
            e.Row.Cells["DestBase"].Value = Settings.Default.DefaultDestBase;
            e.Row.Cells["DestFolderName"].Value = Settings.Default.DefaultDestFolderName;
            e.Row.Cells["ExistingFeedFolder"].Value = Settings.Default.DefaultExistingFeedFolder;
            e.Row.Cells["GuidPrefix"].Value = Settings.Default.DefaultGuidPrefix;
            e.Row.Cells["Mp3Filter"].Value = Settings.Default.DefaultMp3Filter;
            e.Row.Cells["IndirectFilter"].Value = Settings.Default.DefaultIndirectFilter;
            e.Row.Cells["Indirect"].Value = Settings.Default.DefaultIndirect;
            e.Row.Cells["ChannelTitle"].Value = Settings.Default.DefaultChannelTitle;
            e.Row.Cells["ChannelNotes"].Value = Settings.Default.DefaultChannelNotes;
            e.Row.Cells["SortDescending"].Value = Settings.Default.DefaultSortDescending;
            e.Row.Cells["RetainOrphans"].Value = Settings.Default.DefaultRetainOrphans;
            e.Row.Cells["StripBaseName"].Value = Settings.Default.DefaultStripBaseName;
            e.Row.Cells["PrependRelative"].Value = Settings.Default.DefaultPrependRelative;
            e.Row.Cells["RefreshDays"].Value = Settings.Default.DefaultRefreshDays;
            e.Row.Cells["FtpPath"].Value = Settings.Default.DefaultFtpPath;
            e.Row.Cells["FtpUserName"].Value = Settings.Default.DefaultFtpUserName;
            e.Row.Cells["FtpPassword"].Value = Settings.Default.DefaultFtpPassword;
            e.Row.Cells["PermissionRevoked"].Value = Settings.Default.DefaultPermissionRevoked;
            e.Row.Cells["AllowHttps"].Value = Settings.Default.DefaultAllowHttps;
            e.Row.Cells["Wraparound"].Value = Settings.Default.DefaultWraparound;
            e.Row.Cells["MaxWebRequests"].Value = Settings.Default.DefaultMaxWebRequests;
            e.Row.Cells["MaintenanceA"].Value = Settings.Default.DefaultMaintenanceA;
            e.Row.Cells["MaintenanceB"].Value = Settings.Default.DefaultMaintenanceB;
            e.Row.Cells["MaintenanceC"].Value = Settings.Default.DefaultMaintenanceB;
        }

        /// <summary>
        /// Delete the selected row from the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // The index of the row requested for deletion
            // scrapesDataGridView.CurrentCell.RowIndex
            if (scrapesDataGridView.CurrentCell.RowIndex >= 0)
            {
                DataGridViewRow rowToDelete = scrapesDataGridView.Rows[scrapesDataGridView.CurrentCell.RowIndex];
                // Avoid trying to delete the bottom row where a new row is added.
                if (!rowToDelete.IsNewRow)
                {
                    scrapesDataGridView.Rows.Remove(rowToDelete);
                    somethingChanged = true;
                }
            }
        }

        /// <summary>
        /// Select the row when the right mouse button is clicked
        /// </summary>
        /// <param name="sender">The DataGridView control</param>
        /// <param name="e">More info</param>
        private void scrapesDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            if ((e.Button == MouseButtons.Right) && (e.RowIndex != -1))
            {
                DataGridViewRow row = dataGrid.Rows[e.RowIndex];
                dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
                row.Selected = true;
                dataGrid.Focus();
            }
        }

        /// <summary>
        /// Occurs when any cell value changes. Set the variable to remember something changed so that the
        /// user can be warned when closing before saving.
        /// </summary>
        /// <param name="sender">The cell</param>
        /// <param name="e">More info</param>
        private void scrapesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            somethingChanged = true;
        }

        /// <summary>
        /// When a checkbox value changes, this event must be handled to commit the new value.
        /// Otherwise, if the checkbox changes without changing the focus and the user immediately
        /// saves a new file, the new value is not committed and the old value is saved.
        /// </summary>
        /// <param name="sender">The cell</param>
        /// <param name="e">More info</param>
        private void scrapesDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (scrapesDataGridView.IsCurrentCellDirty)
            {
                scrapesDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        /// <summary>
        /// Validate the datatype for each column as needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scrapesDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == scrapesDataGridView.Columns["Enabled_"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["Index"].Index)
            {
                int iii = -1;
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out iii))
                {
                    e.Cancel = true;
                    MessageBox.Show("Enter a four-digit integer from 0001 to 9999.", "Error");
                }
                if ((e.FormattedValue.ToString().Length != 4) || (iii <= 0) || (iii > 9999))
                {
                    e.Cancel = true;
                    MessageBox.Show("Enter a four-digit integer from 0001 to 9999.", "Error");
                }
            }
            if (e.ColumnIndex == scrapesDataGridView.Columns["Url"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["UrlPrefix"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["DestBase"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["DestFolderName"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["ExistingFeedFolder"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["GuidPrefix"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["Mp3Filter"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["IndirectFilter"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["Indirect"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["ChannelTitle"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["ChannelNotes"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["SortDescending"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["RetainOrphans"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["StripBaseName"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["PrependRelative"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["FtpPath"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["FtpUserName"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["FtpPassword"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["PermissionRevoked"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["AllowHttps"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["Wraparound"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["MaintenanceA"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["MaintenanceB"].Index) { return; }
            if (e.ColumnIndex == scrapesDataGridView.Columns["MaintenanceC"].Index) { return; }
            if ((e.ColumnIndex == scrapesDataGridView.Columns["RefreshDays"].Index) ||
                (e.ColumnIndex == scrapesDataGridView.Columns["MaxWebRequests"].Index))
            {
                int iii = -1;
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out iii))
                {
                    e.Cancel = true;
                    MessageBox.Show("Enter an integer from 0 to 31.", "Error");
                }
                else if ((iii < 0) || (iii > 31))
                {
                    e.Cancel = true;
                    MessageBox.Show("Enter an integer from 0 to 31.", "Error");
                }
            }
        }

        /// <summary>
        /// Start a search
        /// </summary>
        /// <param name="sender">Key info</param>
        /// <param name="e">Extra info</param>
        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                DoSearch();
            }
        }

        /// <summary>
        /// Search for the next row with a ChannelTitle containing the search term. Wrap around.
        /// </summary>
        private void DoSearch()
        {
            if (searchTextBox.Text.Length <= 0)
            {
                // Nothing to search for, just return.
                return;
            }
            int curSel = -1;
            bool found = false;
            // Save the index of the currently selected row.
            foreach (DataGridViewRow row in scrapesDataGridView.Rows)
            {
                if (row.Selected)
                {
                    curSel = row.Index;
                    break;
                }
            }
            // Clea the current selection in prep for selecting a new selection.
            scrapesDataGridView.ClearSelection();
            // Search the rows for the search term.
            // If found, but already selected, keep searching for the next row that matches.
            // If the end of the rows are reached, the second iteration finds earlier matches.
            // Watch out for that final row used to add new rows, the cell value will be null.
            for (int i = 0; i < 2; i++)
            {
                foreach (DataGridViewRow row in scrapesDataGridView.Rows)
                {
                    if ((row.Cells["ChannelTitle"].Value != null) &&
                        row.Cells["ChannelTitle"].Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower()) &&
                        (row.Index > curSel))
                    {
                        found = true;
                        row.Selected = true;
                        scrapesDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
                curSel = -1;
            }
        }

        /// <summary>
        /// Show the mp3scraper PDF which describes the attributes.
        /// </summary>
        /// <param name="sender">The menu item</param>
        /// <param name="e">Extra info</param>
        private void pdfLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/ggocek/mp3scraper/blob/master/mp3scraper/mp3scraper.pdf",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
    } // end class mp3scrUI

    /********************************************************/
    // Save the window location and size
    // https://blogs.msdn.microsoft.com/davidrickard/2010/03/08/saving-window-size-and-location-in-wpf-and-winforms/

    // RECT structure required by WINDOWPLACEMENT structure
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;

        public RECT(int left, int top, int right, int bottom)
        {
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
        }
    }

    // POINT structure required by WINDOWPLACEMENT structure
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;

        public POINT(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    // WINDOWPLACEMENT stores the position, size, and state of a window
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct WINDOWPLACEMENT
    {
        public int length;
        public int flags;
        public int showCmd;
        public POINT minPosition;
        public POINT maxPosition;
        public RECT normalPosition;
    }

    public static class WindowPlacement
    {
        private static Encoding encoding = new UTF8Encoding();
        private static XmlSerializer serializer = new XmlSerializer(typeof(WINDOWPLACEMENT));

        [DllImport("user32.dll")]
        private static extern bool SetWindowPlacement(IntPtr hWnd, [In] ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll")]
        private static extern bool GetWindowPlacement(IntPtr hWnd, out WINDOWPLACEMENT lpwndpl);

        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;

        public static void SetPlacement(IntPtr windowHandle, string placementXml)
        {
            if (string.IsNullOrEmpty(placementXml))
            {
                return;
            }

            WINDOWPLACEMENT placement;
            byte[] xmlBytes = encoding.GetBytes(placementXml);

            try
            {
                using (MemoryStream memoryStream = new MemoryStream(xmlBytes))
                {
                    placement = (WINDOWPLACEMENT)serializer.Deserialize(memoryStream);
                }

                placement.length = Marshal.SizeOf(typeof(WINDOWPLACEMENT));
                placement.flags = 0;
                placement.showCmd = (placement.showCmd == SW_SHOWMINIMIZED ? SW_SHOWNORMAL : placement.showCmd);
                SetWindowPlacement(windowHandle, ref placement);
            }
            catch (InvalidOperationException)
            {
                // Parsing placement XML failed. Fail silently.
            }
        }

        public static string GetPlacement(IntPtr windowHandle)
        {
            WINDOWPLACEMENT placement = new WINDOWPLACEMENT();
            GetWindowPlacement(windowHandle, out placement);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8))
                {
                    serializer.Serialize(xmlTextWriter, placement);
                    byte[] xmlBytes = memoryStream.ToArray();
                    return encoding.GetString(xmlBytes);
                }
            }
        }
    }
} // end namespace
