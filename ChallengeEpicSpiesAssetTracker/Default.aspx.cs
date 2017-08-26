using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                string[] asset = new string[0];
                double[] elections = new double[0];
                double[] subterfuge = new double[0];

                ViewState.Add("Asset", asset);
                ViewState.Add("Elections", elections);
                ViewState.Add("Subterfuge", subterfuge);
            }
            
        }

        protected void assetButton_Click(object sender, EventArgs e)
        {

            string[] asset = (string[])ViewState["Asset"];
            double[] elections = (double[])ViewState["Elections"];
            double[] subterfuge = (double[])ViewState["Subterfuge"];

            Array.Resize(ref asset, asset.Length + 1);
            Array.Resize(ref elections, elections.Length + 1);
            Array.Resize(ref subterfuge, subterfuge.Length + 1);

            int assetIndex = asset.GetUpperBound(0);
            int elecIndex = elections.GetUpperBound(0);
            int subtIndex = subterfuge.GetUpperBound(0);

            asset[assetIndex] = assetNameBox.Text;
            elections[elecIndex] = double.Parse(electionsRiggedBox.Text);
            subterfuge[subtIndex] = double.Parse(subterfugeBox.Text);

            ViewState["Asset"] = asset;
            ViewState["Elections"] = elections;
            ViewState["Subterfuge"] = subterfuge;

            // Sum of elections rigged
            // Average of subterfuge
            // Last name entered

            double sumElec = elections.Sum();
            double aveSubt = subterfuge.Average();

            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br>"
                + "Average Acts of Subterfuge per Asset: {1:N2}<br>"
                + "(Last Asset Added: {2})",
                sumElec,
                aveSubt,
                asset[assetIndex]);

            // Clear the textboxes:
            assetNameBox.Text = "";
            electionsRiggedBox.Text = "";
            subterfugeBox.Text = "";
        }
    }
}