namespace ppt2pdf
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.tabPpt2pdf = this.Factory.CreateRibbonTab();
            this.groupPpt2pdf = this.Factory.CreateRibbonGroup();
            this.buttonSaveAsPDF = this.Factory.CreateRibbonButton();
            this.buttonSaveAsEPS = this.Factory.CreateRibbonButton();
            this.buttonShowSettigs = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.tabPpt2pdf.SuspendLayout();
            this.groupPpt2pdf.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // tabPpt2pdf
            // 
            this.tabPpt2pdf.Groups.Add(this.groupPpt2pdf);
            this.tabPpt2pdf.Label = "ppt2pdf";
            this.tabPpt2pdf.Name = "tabPpt2pdf";
            // 
            // groupPpt2pdf
            // 
            this.groupPpt2pdf.Items.Add(this.buttonSaveAsPDF);
            this.groupPpt2pdf.Items.Add(this.buttonSaveAsEPS);
            this.groupPpt2pdf.Items.Add(this.buttonShowSettigs);
            this.groupPpt2pdf.Label = "Save figure for latex";
            this.groupPpt2pdf.Name = "groupPpt2pdf";
            // 
            // buttonSaveAsPDF
            // 
            this.buttonSaveAsPDF.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonSaveAsPDF.Image = global::ppt2pdf.Properties.Resources.if_application_pdf_28857;
            this.buttonSaveAsPDF.Label = "Save As PDF";
            this.buttonSaveAsPDF.Name = "buttonSaveAsPDF";
            this.buttonSaveAsPDF.ShowImage = true;
            this.buttonSaveAsPDF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonSaveAsPDF_Click);
            // 
            // buttonSaveAsEPS
            // 
            this.buttonSaveAsEPS.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonSaveAsEPS.Image = global::ppt2pdf.Properties.Resources.image_x_eps;
            this.buttonSaveAsEPS.Label = "Save As EPS";
            this.buttonSaveAsEPS.Name = "buttonSaveAsEPS";
            this.buttonSaveAsEPS.ShowImage = true;
            this.buttonSaveAsEPS.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonSaveAsEPS_Click);
            // 
            // buttonShowSettigs
            // 
            this.buttonShowSettigs.Image = global::ppt2pdf.Properties.Resources.if_gnome_system_config_28671;
            this.buttonShowSettigs.Label = "Settings";
            this.buttonShowSettigs.Name = "buttonShowSettigs";
            this.buttonShowSettigs.ShowImage = true;
            this.buttonShowSettigs.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonShowSettigs_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tabPpt2pdf);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tabPpt2pdf.ResumeLayout(false);
            this.tabPpt2pdf.PerformLayout();
            this.groupPpt2pdf.ResumeLayout(false);
            this.groupPpt2pdf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabPpt2pdf;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupPpt2pdf;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSaveAsPDF;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSaveAsEPS;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonShowSettigs;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
