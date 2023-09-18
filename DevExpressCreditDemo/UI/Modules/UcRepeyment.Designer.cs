namespace DevExpressCreditDemo.UI.Modules
{
    partial class UcRepeyment
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
            this.gridControlRepeyment = new DevExpress.XtraGrid.GridControl();
            this.gridViewRepeyment = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRepeyment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRepeyment)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlRepeyment
            // 
            this.gridControlRepeyment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRepeyment.Location = new System.Drawing.Point(0, 0);
            this.gridControlRepeyment.MainView = this.gridViewRepeyment;
            this.gridControlRepeyment.Name = "gridControlRepeyment";
            this.gridControlRepeyment.Size = new System.Drawing.Size(734, 615);
            this.gridControlRepeyment.TabIndex = 0;
            this.gridControlRepeyment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRepeyment});
            // 
            // gridViewRepeyment
            // 
            this.gridViewRepeyment.GridControl = this.gridControlRepeyment;
            this.gridViewRepeyment.Name = "gridViewRepeyment";
            // 
            // UcRepeyment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlRepeyment);
            this.Name = "UcRepeyment";
            this.Size = new System.Drawing.Size(734, 615);
            this.Load += new System.EventHandler(this.UcRepeyment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRepeyment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRepeyment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlRepeyment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRepeyment;
    }
}
