using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp3scrUI
{
    /// <summary>
    /// The class describes the attributes for scraping an individual remote location, saving an RSS file locally,
    /// and uploading the RSS file to an FTP site. This corresponds to a location in the mp3scraper config file.
    /// </summary>
    public class ScrapeItem
    {
        /// <summary>
        /// Each item has a unique index between 0001 and 9999.
        /// </summary>
        public string Index { get; set; }

        /// <summary>
        /// Scrape the location if true, else ignore it.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// The location to be scraped.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Within HTML or XML markup, this marks the beginning of an mp3 link. Usally this is "=",
        /// but some tricky locations are, well, tricky,
        /// </summary>
        public string UrlPrefix { get; set; }

        /// <summary>
        /// The base name of the RSS file for the current location.
        /// </summary>
        public string DestBase { get; set; }

        /// <summary>
        /// The name of the folder on the local device for the RSS file.
        /// </summary>
        public string DestFolderName { get; set; }

        /// <summary>
        /// The name of the folder for a previous version of the RSS file, needed when using refreshDays.
        /// </summary>
        public string ExistingFeedFolder { get; set; }

        /// <summary>
        /// Within an RSS file, each RSS item has a guid. mp3scraper prepends this prefix before a unique value.
        /// </summary>
        public string GuidPrefix { get; set; }

        /// <summary>
        /// If non-empty, an MP3 link must contain this string. If this begins with !, the mp3 link
        /// must NOT contain this string.
        /// </summary>
        public string Mp3Filter { get; set; }

        /// <summary>
        /// Not currently used by mp3scraper.
        /// </summary>
        public string IndirectFilter { get; set; }

        /// <summary>
        /// Not currently used by mp3scraper.
        /// </summary>
        public bool Indirect { get; set; }

        /// <summary>
        /// The channel title for an RSS file, usually a short description for the location.
        /// </summary>
        public string ChannelTitle { get; set; }

        /// <summary>
        /// The channel notes for an RSS file, usually used to explain why the location needs to be scraped.
        /// </summary>
        public string ChannelNotes { get; set; }

        /// <summary>
        /// True if the location is sorted in reverse chronological order.
        /// </summary>
        public bool SortDescending { get; set; }

        /// <summary>
        /// When saving the links to ALL mp3s at a location, sometimes the publisher removes a link but retains
        /// the file, and this setting tells mp3scraper to keep the old link. If only saving a few recent links
        /// (the usual usage), this setting is false.
        /// </summary>
        public bool RetainOrphans { get; set; }

        /// <summary>
        /// True if mp3scraper should strip the mp3 link address from the base name and replaced with prependRelative.
        /// Otherwise the whole mp3 link is used as-is.
        /// </summary>
        public bool StripBaseName { get; set; }

        /// <summary>
        /// A partial web address to prepend before the base name, used with StripBaseName.
        /// </summary>
        public string PrependRelative { get; set; }

        /// <summary>
        /// The number of days to wait between successful scrapes. Zero for no waiting.
        /// </summary>
        public int RefreshDays { get; set; }

        /// <summary>
        /// The ftp host and directory path for uploading the generated RSS file.
        /// </summary>
        public string FtpPath { get; set; }

        /// <summary>
        /// The FTP user name.
        /// </summary>
        public string FtpUserName { get; set; }

        /// <summary>
        /// The FTP user name.
        /// </summary>
        public string FtpPassword { get; set; }

        /// <summary>
        /// The reason why a publisher asked you to stop scraping. This does not actually disable the scrape,
        /// just a note to remember why you were asked.
        /// </summary>
        public string PermissionRevoked { get; set; }

        /// <summary>
        /// If false, changes the protocol of the link in the RSS file to http even if the remote location
        /// specifies https. Technocally, RSS says that https is not a valied protocol.
        /// </summary>
        public bool AllowHttps { get; set; }

        /// <summary>
        /// Whwn true, mp3scraper uses an elaborate algoithm to select an MP3 link even though the publisher
        /// has stopped updating the RSS feed. This allows you to cycle through a dead feed.
        /// </summary>
        public bool Wraparound { get; set; }

        /// <summary>
        /// mp3scraper hits each remote mp3 file to check for existence and the publish date, but when there are
        /// a lot of links, the remote site may throttle the scrape. This causes mp3scraper to stop scraping
        /// after the specified number of links have been verified. Just make sure SortDescending is correct for
        /// the location.
        /// </summary>
        public int MaxWebRequests { get; set; }

        /// <summary>
        /// User comment A, mp3scraper ignores this.
        /// </summary>
        public string MaintenanceA { get; set; }

        /// <summary>
        /// User comment B, mp3scraper ignores this.
        /// </summary>
        public string MaintenanceB { get; set; }

        /// <summary>
        /// User comment C, mp3scraper ignores this.
        /// </summary>
        public string MaintenanceC { get; set; }

        public ScrapeItem()
        {
            Index = "0000";
        }

        /// <summary>
        /// Given a row from the grid, load the current instance of this ScrapeItem.
        /// </summary>
        /// <param name="dgvr">A row from a DataGridView</param>
        /// <returns>The current instance loaded with the properties from the row.</returns>
        public ScrapeItem Load(DataGridViewRow dgvr)
        {
            this.Index = dgvr.Cells["Index"].Value.ToString();
            this.Enabled = bool.Parse(dgvr.Cells["Enabled_"].Value.ToString());
            this.Url = dgvr.Cells["Url"].Value.ToString();
            this.UrlPrefix = dgvr.Cells["UrlPrefix"].Value.ToString();
            this.DestBase = dgvr.Cells["DestBase"].Value.ToString();
            this.DestFolderName = dgvr.Cells["DestFolderName"].Value.ToString();
            this.ExistingFeedFolder = dgvr.Cells["ExistingFeedFolder"].Value.ToString();
            this.GuidPrefix = dgvr.Cells["GuidPrefix"].Value.ToString();
            this.Mp3Filter = dgvr.Cells["Mp3Filter"].Value.ToString();
            this.IndirectFilter = dgvr.Cells["IndirectFilter"].Value.ToString();
            this.Indirect = bool.Parse(dgvr.Cells["Indirect"].Value.ToString());
            this.ChannelTitle = dgvr.Cells["ChannelTitle"].Value.ToString();
            this.ChannelNotes = dgvr.Cells["ChannelNotes"].Value.ToString();
            this.SortDescending = bool.Parse(dgvr.Cells["SortDescending"].Value.ToString());
            this.RetainOrphans = bool.Parse(dgvr.Cells["RetainOrphans"].Value.ToString());
            this.StripBaseName = bool.Parse(dgvr.Cells["StripBaseName"].Value.ToString());
            this.PrependRelative = dgvr.Cells["PrependRelative"].Value.ToString();
            this.RefreshDays = int.Parse(dgvr.Cells["RefreshDays"].Value.ToString());
            this.FtpPath = dgvr.Cells["FtpPath"].Value.ToString();
            this.FtpUserName = dgvr.Cells["FtpUserName"].Value.ToString();
            this.FtpPassword = dgvr.Cells["FtpPassword"].Value.ToString();
            this.PermissionRevoked = dgvr.Cells["PermissionRevoked"].Value.ToString();
            this.AllowHttps = bool.Parse(dgvr.Cells["AllowHttps"].Value.ToString());
            this.Wraparound = bool.Parse(dgvr.Cells["Wraparound"].Value.ToString());
            this.MaxWebRequests = int.Parse(dgvr.Cells["MaxWebRequests"].Value.ToString());
            this.MaintenanceA = dgvr.Cells["MaintenanceA"].Value.ToString();
            this.MaintenanceB = dgvr.Cells["MaintenanceB"].Value.ToString();
            this.MaintenanceC = dgvr.Cells["MaintenanceC"].Value.ToString();

            return this;
        }
    }
}
