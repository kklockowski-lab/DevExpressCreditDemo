namespace DevExpressCreditDemo.UI.Modules
{
    partial class UcClients
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
            this.gridControlClients = new DevExpress.XtraGrid.GridControl();
            this.gridViewClients = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlClients
            // 
            this.gridControlClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlClients.Location = new System.Drawing.Point(0, 0);
            this.gridControlClients.MainView = this.gridViewClients;
            this.gridControlClients.Name = "gridControlClients";
            this.gridControlClients.Size = new System.Drawing.Size(659, 527);
            this.gridControlClients.TabIndex = 0;
            this.gridControlClients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClients});
            // 
            // gridViewClients
            // 
            this.gridViewClients.GridControl = this.gridControlClients;
            this.gridViewClients.Name = "gridViewClients";
            // 
            // UcClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlClients);
            this.Name = "UcClients";
            this.Size = new System.Drawing.Size(659, 527);
            this.Load += new System.EventHandler(this.UcClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlClients;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClients;
    }
}
