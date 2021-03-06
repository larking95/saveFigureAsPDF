﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace ppt2pdf
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            SaveFigure saveFigure = new SaveFigure();
            Ribbon1 ribbon1 = new Ribbon1();
            var userControlSettingExchanger = new UserControlSettingExchanger();
            UserControlSettingExcahngerWrap userControlSettingExcahngerWrap = new UserControlSettingExcahngerWrap();
            var customTaskPanes = this.CustomTaskPanes.Add(userControlSettingExcahngerWrap, "設定ペイン");
            customTaskPanes.Visible = true;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO で生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
