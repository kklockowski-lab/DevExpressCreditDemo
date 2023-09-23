namespace DevExpressCreditDemo.UI.Modules
{
    partial class UcRepayment
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridViewRepeyment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn5});
            this.gridViewRepeyment.GridControl = this.gridControlRepeyment;
            this.gridViewRepeyment.Name = "gridViewRepeyment";
            this.gridViewRepeyment.OptionsBehavior.ReadOnly = true;
            this.gridViewRepeyment.OptionsView.ShowDetailButtons = false;
            this.gridViewRepeyment.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewRepeyment_RowStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Imie";
            this.gridColumn1.FieldName = "FirstName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nazwisko";
            this.gridColumn2.FieldName = "LastName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Data wpłaty";
            this.gridColumn4.FieldName = "Date";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Wartość";
            this.gridColumn3.DisplayFormat.FormatString = "c2";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "Value";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Dzień spłaty";
            this.gridColumn5.FieldName = "DayOfPement";
            this.gridColumn5.Name = "gridColumn5";
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
