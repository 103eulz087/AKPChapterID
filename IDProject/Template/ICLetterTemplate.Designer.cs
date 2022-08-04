namespace IDProject.Template
{
    partial class ICLetterTemplate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrrollno = new DevExpress.XtraReports.UI.XRLabel();
            this.xrqrcode = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0.9579976F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrrollno,
            this.xrqrcode,
            this.xrlogo,
            this.xrLabel2,
            this.xrLabel1,
            this.xrPictureBox1});
            this.Detail.HeightF = 1168.666F;
            this.Detail.Name = "Detail";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FullName]")});
            this.xrLabel3.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.ForeColor = System.Drawing.Color.White;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(90.20834F, 1074.083F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(368.3633F, 27.16663F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "JUAN DELA CRUZ ANGELES";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrrollno
            // 
            this.xrrollno.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RollNumber]")});
            this.xrrollno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrrollno.LocationFloat = new DevExpress.Utils.PointFloat(112.5F, 916.1666F);
            this.xrrollno.Multiline = true;
            this.xrrollno.Name = "xrrollno";
            this.xrrollno.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrrollno.SizeF = new System.Drawing.SizeF(270.4467F, 16.74999F);
            this.xrrollno.StylePriority.UseFont = false;
            this.xrrollno.StylePriority.UseTextAlignment = false;
            this.xrrollno.Text = "PAY_CODEDESC";
            this.xrrollno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrqrcode
            // 
            this.xrqrcode.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ID]")});
            this.xrqrcode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrqrcode.LocationFloat = new DevExpress.Utils.PointFloat(141.6667F, 861.4583F);
            this.xrqrcode.Multiline = true;
            this.xrqrcode.Name = "xrqrcode";
            this.xrqrcode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrqrcode.SizeF = new System.Drawing.SizeF(270.4467F, 16.74999F);
            this.xrqrcode.StylePriority.UseFont = false;
            this.xrqrcode.StylePriority.UseTextAlignment = false;
            this.xrqrcode.Text = "PAY_CODEDESC";
            this.xrqrcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlogo
            // 
            this.xrlogo.LocationFloat = new DevExpress.Utils.PointFloat(666.6667F, 62.5F);
            this.xrlogo.Name = "xrlogo";
            this.xrlogo.SizeF = new System.Drawing.SizeF(128.125F, 117.7083F);
            this.xrlogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(23.95833F, 914.1666F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(88.54166F, 18.75F);
            this.xrLabel2.Text = "Roll Number:";
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(23.95833F, 861.4583F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(117.7083F, 18.75F);
            this.xrLabel1.Text = "QRCODE / ID No.:";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::IDProject.Properties.Resources.ICBLANKTEMPLATE1, true);
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(827.0001F, 1168.209F);
            // 
            // ICLetterTemplate
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 1);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.UI.XRPictureBox xrlogo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrrollno;
        private DevExpress.XtraReports.UI.XRLabel xrqrcode;
    }
}
