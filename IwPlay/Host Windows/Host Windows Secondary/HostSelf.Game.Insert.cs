using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDB = IwPlay.Systems.IwP_Main_Database.UserInfo;
using DevDB = IwPlay.Systems.IwP_Main_Database.DevInfo;
using BaiqiSoft.HtmlEditorControl;

namespace IwPlay.Hosts.Secondary
{
    public partial class HostSelf_GameEditor_Insert : Form
    {

        /// <summary>
        /// Editor HTML
        /// </summary>
        MstHtmlEditor HTMLEditor = new MstHtmlEditor();

        public HostSelf_GameEditor_Insert()
        {
            InitializeComponent();
        }

        private void HostSelf_Load(object sender, EventArgs e)
        {
            // Inserir os desenvolvedores no combo de seletor
            foreach (string s in UserDB.Desenvolvedor) DeveloperFilter.Items.Add(s.ToUpper());

            // Criar editor HTML
            EditorHandler.Controls.Add(HTMLEditor);
            HTMLEditor.Dock = DockStyle.Fill;

        }

        private void SearchFilesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
