using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Formularioa : UserControl
    {
        public Formularioa()
        {
            InitializeComponent();

            this.Resize += new EventHandler(MainForm_Resize);
            UpdatePanelSizes();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            UpdatePanelSizes();
        }

        public void UpdatePanelSizes()
        {
            UpdateRightPanel();
        }

        private void UpdateRightPanel()
        {

            int fullWidth = (int)rightPanelTableLayout.Width;
            int leftWidth = (int)(this.ClientSize.Width * 0.2);
            int rightWidth = (int)(this.ClientSize.Width * 0.8);

            //Panelak zentratu
            titleBody.Width = fullWidth;
            rpLeftNamePanel.Width = leftWidth;
            rpLeftDescriptionPanel.Width = leftWidth;
            rpRightInputPanel.Width = rightWidth;
            //Titulua zentratu
            titleBody.Width = fullWidth;
            titleBodyLabel.Width = fullWidth;

            //Labelak zentratu bertikalki eta horizontalki
            NHibernateHelper.zentratuBertikalEtaHorizontalki(rpLeftNamePanelLabel, rpLeftNamePanel);
            NHibernateHelper.zentratuBertikalEtaHorizontalki(rpLeftNamePanelTextbox, rpRightInputPanel);
            NHibernateHelper.zentratuBertikalEtaHorizontalki(rpLeftDescriptionPanelLabel, rpLeftDescriptionPanel);
            rpLeftDescriptionPanelTextBox.Width = (int)(rpRightDescriptionInputPanel.Width * 0.7);
            rpLeftDescriptionPanelTextBox.Height = (int)(rpRightDescriptionInputPanel.Height * 0.8);
            NHibernateHelper.zentratuBertikalEtaHorizontalki(rpLeftDescriptionPanelTextBox, rpRightDescriptionInputPanel);

        }
    }
}
