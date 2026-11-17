using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace NEA_Music_Managment_and_reccomendation
{
    public partial class Form3 : Form
    {
        public string UserLoggedIn { get; private set; }
        private List<AlbumData> albuminfo = new List<AlbumData>();

        private List<UserI> userinf = new List<UserI>();
        private string FilepathAlbum = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AlbumDatabase.json");


        public Form3(string username)
        {
            InitializeComponent();
            UserLoggedIn = username;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            progressBar2.Hide();
            label3.Text = UserLoggedIn;
            string UserFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, UserLoggedIn + "'sFile.json");


            string Albums = File.ReadAllText(FilepathAlbum);
            string ratings = File.ReadAllText(UserFile);
            userinf = JsonSerializer.Deserialize<List<UserI>>(ratings);
            albuminfo = JsonSerializer.Deserialize<List<AlbumData>>(Albums);
            List<AlbumData> albumssorted = albuminfo.OrderBy(a => a.AlbumName).ToList();
            string JsonFormatted = JsonSerializer.Serialize(albumssorted);
            File.WriteAllText(FilepathAlbum, JsonFormatted);
            dataGridView1.DataSource = albumssorted;
            SetupGrid();
            AlbumsListenedtoo();
            RatingAverage();

        }
        private void RatingAverage()
        {
            double avg = 0;
            double count = 0;
            for (int p = 0; p < userinf.Count; p++)
            {

                for (int q = 0; q < userinf[p].Rates.Count; q++)
                {
                    avg = avg + userinf[p].Rates[q].Rate;
                    count++;

                }
            }

            double sum = avg / count;
            double avgrating = Math.Round(sum, 1);
            label6.Text = avgrating.ToString();
        }
        private void AlbumsListenedtoo()
        {
            label4.Text = Convert.ToString(userinf[0].Rates.Count);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveRatings();

            Environment.Exit(0);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Search()
        {
            List<AlbumData> FilteredAlbums = new List<AlbumData>();
            SaveRatings();
            if (SearchBox.Text != null | !((SearchBox.Text).ToString().IsWhiteSpace()))
            {
                for (int i = 0; i < albuminfo.Count; i++)
                {
                    if ((albuminfo[i].AlbumName.ToUpper().Contains(SearchBox.Text.ToUpper())) == true || albuminfo[i].ArtistName.ToUpper().Contains(SearchBox.Text.ToUpper()) == true)
                    {
                        if (FilterBox.SelectedItem == null | FilterBox.SelectedItem == "")
                        {
                            FilteredAlbums.Add(albuminfo[i]);
                        }
                        else
                        {
                            if (albuminfo[i].Genre == FilterBox.SelectedItem.ToString())
                            {
                                FilteredAlbums.Add(albuminfo[i]);
                            }

                        }

                    }
                }

            }
            else
            {
                for (int i = 0; i < albuminfo.Count; i++)
                {
                    if (FilterBox.SelectedItem == null | FilterBox.SelectedItem == "")
                    {
                        FilteredAlbums.Add(albuminfo[i]);
                    }
                    else
                    {

                        if (albuminfo[i].Genre == FilterBox.SelectedItem.ToString())
                        {
                            FilteredAlbums.Add(albuminfo[i]);
                        }

                    }
                }
            }


            dataGridView1.DataSource = FilteredAlbums;
            SetupGrid();
            AlbumsListenedtoo();
            RatingAverage();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void SaveRatings()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool valid = false;
                try
                {
                    Convert.ToDouble(dataGridView1.Rows[i].Cells["Ratings"].Value);
                    valid = true;
                }
                catch (Exception)
                {
                    dataGridView1.Rows[i].Cells["Ratings"].Value = null;
                    valid = false;
                }
                if (valid == true)
                {
                    string Value = Convert.ToString(dataGridView1.Rows[i].Cells["Ratings"].Value);
                    string Hash = dataGridView1.Rows[i].Cells["Hash"].Value.ToString();


                    for (int j = 0; j < userinf.Count; j++)
                    {
                        bool MadeNull = false;
                        bool AlreadyExist = false;

                        for (int k = 0; k < userinf[j].Rates.Count; k++)
                        {
                            if (userinf[j].Rates[k].Hash == Hash)
                            {
                                AlreadyExist = true;
                                if (string.IsNullOrEmpty(Value))
                                {
                                    userinf[j].Rates.RemoveAt(k);
                                }
                                else
                                {
                                    userinf[j].Rates[k].Rate = Math.Round(Convert.ToDouble(Value), 1); ;
                                }
                                break;
                            }

                        }
                        if (!AlreadyExist && !string.IsNullOrEmpty(Value))
                        {

                            RatingInfo addValue = new RatingInfo();
                            addValue.Hash = Hash;
                            addValue.Rate = Math.Round(Convert.ToDouble(Value), 1);
                            userinf[j].Rates.Add(addValue);
                            break;

                        }

                    }

                }







            }
            string UserFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, UserLoggedIn + "'sFile.json");
            File.WriteAllText(UserFile, JsonSerializer.Serialize(userinf));
        }
        private void SetupGrid()
        {
            if (!dataGridView1.Columns.Contains("Ratings"))
            {
                dataGridView1.Columns.Add("Ratings", "Ratings");
            }
            if (dataGridView1.Columns.Contains("Hash"))
            {
                dataGridView1.Columns["Hash"].Visible = false;
            }
            dataGridView1.Columns["AlbumName"].ReadOnly = true;
            dataGridView1.Columns["ArtistName"].ReadOnly = true;
            dataGridView1.Columns["Genre"].ReadOnly = true;
            dataGridView1.Columns["YoR"].ReadOnly = true;
            dataGridView1.Columns["Ratings"].ReadOnly = false;
            for (int i = 0; i < userinf.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    for (int k = 0; k < userinf[i].Rates.Count; k++)
                    {
                        if (userinf[i].Rates[k].Hash.ToString() == dataGridView1.Rows[j].Cells["Hash"].Value.ToString())
                        {
                            dataGridView1.Rows[j].Cells["Ratings"].Value = userinf[i].Rates[k].Rate.ToString();
                        }
                    }

                }

            }
        }

        private void FilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindRecommendation();
        }
        private void FindRecommendation()
        {
            Dictionary<string, double> AveragesGenre = new Dictionary<string, double>();
            Dictionary<string, double> AveragesYear = new Dictionary<string, double>();
            Dictionary<string, string> GenresAndHash = new Dictionary<string, string>();
            Dictionary<string, int> HowManyValuesGenre = new Dictionary<string, int>();
            Dictionary<string, int> HowManyValuesYears = new Dictionary<string, int>();
            Dictionary<string, string> YearsAndHash = new Dictionary<string, string>();
            List<string> Hashes = new List<string>();
            List<string> YoR = new List<string>();
            List<string> genresRated = new List<string>();
            for (int i = 0; i < userinf.Count; i++)
            {
                for (int j = 0; j < userinf[i].Rates.Count; j++)
                {
                    Hashes.Add(userinf[i].Rates[j].Hash);
                }
            }
            for (int i = 0; i < albuminfo.Count; i++)
            {
                if (Hashes.Contains(albuminfo[i].Hash) && !genresRated.Contains(albuminfo[i].Hash))
                {
                    if (!genresRated.Contains(albuminfo[i].Genre))
                    {
                        genresRated.Add(albuminfo[i].Genre);
                    }
                    GenresAndHash.Add(albuminfo[i].Hash, albuminfo[i].Genre);

                }
            }
            for (int i = 0; i < albuminfo.Count; i++)
            {
                if (Hashes.Contains(albuminfo[i].Hash) && !YoR.Contains(albuminfo[i].YoR.ToString()))
                {
                    YoR.Add(albuminfo[i].YoR.ToString());
                }
                YearsAndHash.Add(albuminfo[i].Hash, albuminfo[i].YoR.ToString());
            }
            for (int i = 0; i < userinf.Count; i++)
            {
                for (int j = 0; j < userinf[i].Rates.Count; j++)
                {
                    if (GenresAndHash.TryGetValue(userinf[i].Rates[j].Hash, out string genre))
                    {
                        //checks to see if the genre value for the dictionary has been changed yet
                        if (!AveragesGenre.ContainsKey(genre))
                        {
                            AveragesGenre[genre] = 0;
                            HowManyValuesGenre[genre] = 0;
                        }
                        AveragesGenre[genre] += userinf[i].Rates[j].Rate;
                        HowManyValuesGenre[genre] += 1;
                    }
                }

            }
            for (int i = 0; i < HowManyValuesGenre.Keys.ToList().Count; i++)
            {
                string genre = HowManyValuesGenre.Keys.ToList()[i];
                AveragesGenre[genre] = Math.Round(AveragesGenre[genre] / HowManyValuesGenre[genre], 1);
            }
            for (int i = 0; i < userinf.Count; i++)
            {
                for (int j = 0; j < userinf[i].Rates.Count; j++)
                {
                    if (YearsAndHash.TryGetValue(userinf[i].Rates[j].Hash, out string Years))
                    {
                        if (!AveragesYear.ContainsKey(Years))
                        {
                            AveragesYear[Years] = 0;
                            HowManyValuesYears[Years] = 0;
                        }
                        AveragesYear[Years] += userinf[i].Rates[j].Rate;
                        HowManyValuesYears[Years] += 1;
                    }
                }
            }
            for (int i = 0; i < HowManyValuesYears.Keys.ToList().Count; i++)
            {
                string Years = HowManyValuesYears.Keys.ToList()[i];
                AveragesYear[Years] = Math.Round(AveragesYear[Years] / HowManyValuesYears[Years], 1);
            }
            string SortedAverageGenre = AveragesGenre.OrderByDescending(x => x.Value).FirstOrDefault().Key;
            string SortedAverageYear = AveragesYear.OrderByDescending(x => x.Value).FirstOrDefault().Key;
            List<string> HashesSameYear = new List<string>();
            List<string> HashesSameGenre = new List<string>();
            for (int i = 0; i < albuminfo.Count; i++)
            {
                if (albuminfo[i].YoR.ToString() == SortedAverageYear)
                {
                    HashesSameYear.Add(albuminfo[i].Hash);
                }
            }
            for (int i = 0; i < albuminfo.Count; i++)
            {
                if (albuminfo[i].Genre.ToString() == SortedAverageGenre)
                {
                    HashesSameGenre.Add(albuminfo[i].Hash);
                }
            }

            int CountHowManyGenres = 0;
            List<string> RatedAlbums = new List<string>();

            for (int i = 0; i < userinf.Count; i++)
            {
                for (int j = 0; j < userinf[i].Rates.Count; j++)
                {
                    RatedAlbums.Add(userinf[i].Rates[j].Hash.ToString());
                }
            }
            int CountHowManyYears = 0;
            for (int k = 0; k < HashesSameYear.Count; k++)
            {
                if (!RatedAlbums.Contains(HashesSameYear[k]))
                {
                    CountHowManyYears += 1;
                }
            }
            for (int k = 0; k < HashesSameGenre.Count; k++)
            {
                if (!RatedAlbums.Contains(HashesSameGenre[k]))
                {
                    CountHowManyGenres += 1;
                }

            }
            if (CountHowManyYears == 0)
            {
                SortedAverageYear = (string)AveragesYear.OrderByDescending(x => x.Value).Skip(1).FirstOrDefault().Key;
            }
            if (CountHowManyGenres == 0)
            {
                SortedAverageGenre = (string)AveragesGenre.OrderByDescending(x => x.Value).Skip(1).FirstOrDefault().Key;
            }


            if (SortedAverageGenre.IsWhiteSpace())
            {
                label8.Text = "Not Enough info";
                label9.Text = "Not Enough info";

            }


            List<string> BestFit = new List<string>();
            List<string> ALbumsFavGenre = new List<string>();
            Dictionary<int, string> HowmanySteps = new Dictionary<int, string>();
            List<string> orderderedYears = AveragesYear.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            List<string> orderderedGenres = AveragesGenre.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            AlbumData TopValue = null;
            foreach (string genre in orderderedGenres)
            {
                bool matchfound = false;
                foreach (string years in orderderedYears)
                {
                    TopValue = albuminfo.FirstOrDefault(a => a.Genre == genre && a.YoR.ToString() == years && !RatedAlbums.Contains(a.Hash));
                    if (TopValue != null)
                    {
                        matchfound = true;
                        break;
                    }

                }
                if (matchfound)
                {
                    break;
                }
            }
            if (TopValue == null)
            {
                label8.Text = "Not Enough Info";
                label9.Text = "Not Enough Info";
                label10.Text = "Not Enough Info";
            }
            else
            {
                    label8.Text = TopValue.AlbumName;
                    label9.Text = TopValue.YoR.ToString();
                    label10.Text = TopValue.Genre;



            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            SaveRatings();
            SetupGrid();
            AlbumsListenedtoo();
            RatingAverage();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }


    public class AlbumData
    {
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public string Genre { get; set; }
        public string Hash { get; set; }
        public int YoR { get; set; }

    }

    public class UserI
    {
        public string Username { get; set; }
        public List<RatingInfo> Rates { get; set; } = new List<RatingInfo>();
    }
    public class RatingInfo
    {
        public string Hash { get; set; }
        public double Rate { get; set; }
    }
}

