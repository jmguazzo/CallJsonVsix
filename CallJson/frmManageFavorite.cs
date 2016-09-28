using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallJson
{
    public partial class frmManageFavorite : Form
    {
        internal Favorite Favorite { get; private set; }


        public frmManageFavorite()
        {
            InitializeComponent();
        }

        internal void Init(Favorite favorite)
        {
            txtBody.Text = favorite.Body;
            txtName.Text = favorite.Name;
            txtUri.Text = favorite.Url;
            this.Favorite = favorite;
        }
        internal void ApplyChanges()
        {
            Favorite.Body = txtBody.Text  ;
            Favorite.Name=txtName.Text  ;
            Favorite.Url = txtUri.Text ;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            Close();
        }
    }
}
