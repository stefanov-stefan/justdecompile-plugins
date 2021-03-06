/* Reflexil Copyright (c) 2007-2012 Sebastien LEBRETON

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. */

#region " Imports "
using System;
using System.Windows.Forms;
using Reflexil.Compilation;
using Reflexil.Properties;
using Reflexil.Utils;
#endregion

namespace Reflexil.Forms
{
	public partial class ConfigureForm: Form
    {

        #region " Events "
        private void ConfigureForm_Load(object sender, EventArgs e)
        {
            foreach (ENumericBase item in System.Enum.GetValues(typeof(ENumericBase)))
            {
                this.InputBase.Items.Add(item);
                this.RowBase.Items.Add(item);
                this.OperandBase.Items.Add(item);
            }
            foreach (ESupportedLanguage item in System.Enum.GetValues(typeof(ESupportedLanguage)))
            {
                this.Language.Items.Add(item);
            }
            this.InputBase.SelectedItem = Settings.Default.InputBase;
            this.RowBase.SelectedItem = Settings.Default.RowIndexDisplayBase;
            this.OperandBase.SelectedItem = Settings.Default.OperandDisplayBase;
            this.Language.SelectedItem = Settings.Default.Language;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Settings.Default.InputBase = (ENumericBase)this.InputBase.SelectedItem;
            Settings.Default.RowIndexDisplayBase = (ENumericBase)this.RowBase.SelectedItem;
            Settings.Default.OperandDisplayBase = (ENumericBase)this.OperandBase.SelectedItem;
            Settings.Default.Language = (ESupportedLanguage)this.Language.SelectedItem;
            Settings.Default.Save();
        }
        #endregion

        #region " Methods "
        public ConfigureForm()
        {
            InitializeComponent();
        }
        #endregion

	}
}