namespace DevExpressCreditDemo.UI.Modules
{
    partial class UcAgreement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControlAgreement = new DevExpress.XtraGrid.GridControl();
            this.gridViewAgrement = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAgreement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAgrement)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlAgreement
            // 
            this.gridControlAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAgreement.Location = new System.Drawing.Point(0, 0);
            this.gridControlAgreement.MainView = this.gridViewAgrement;
            this.gridControlAgreement.Name = "gridControlAgreement";
            this.gridControlAgreement.Size = new System.Drawing.Size(943, 510);
            this.gridControlAgreement.TabIndex = 0;
            this.gridControlAgreement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAgrement});
            // 
            // gridViewAgrement
            // 
            this.gridViewAgrement.GridControl = this.gridControlAgreement;
            this.gridViewAgrement.Name = "gridViewAgrement";
            this.gridViewAgrement.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewAgrement_RowStyle);
            // 
            // UcAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlAgreement);
            this.Name = "UcAgreement";
            this.Size = new System.Drawing.Size(943, 510);
            this.Load += new System.EventHandler(this.UcAgreement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAgreement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAgrement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlAgreement;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAgrement;
    }
}
