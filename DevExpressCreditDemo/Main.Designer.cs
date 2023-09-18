namespace DevExpressCreditDemo
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementMain = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctrCustomers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctrAgreementActive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctrPeyemnts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctrStatMonhtlyDiff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuElementAbout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuElementExit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(260, 31);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(431, 442);
            this.mainContainer.TabIndex = 0;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementMain,
            this.accordionControlElementReport,
            this.accordionControlElement6});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 442);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementMain
            // 
            this.accordionControlElementMain.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ctrCustomers,
            this.ctrAgreementActive,
            this.ctrPeyemnts});
            this.accordionControlElementMain.Expanded = true;
            this.accordionControlElementMain.Name = "accordionControlElementMain";
            this.accordionControlElementMain.Text = "Zarządzanie";
            // 
            // ctrCustomers
            // 
            this.ctrCustomers.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.ctrCustomers.Name = "ctrCustomers";
            this.ctrCustomers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ctrCustomers.Text = "Klienci";
            this.ctrCustomers.Click += new System.EventHandler(this.ctrCustomers_Click);
            // 
            // ctrAgreementActive
            // 
            this.ctrAgreementActive.Name = "ctrAgreementActive";
            this.ctrAgreementActive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ctrAgreementActive.Text = "Umowy";
            this.ctrAgreementActive.Click += new System.EventHandler(this.ctrAgreementActive_Click);
            // 
            // ctrPeyemnts
            // 
            this.ctrPeyemnts.Name = "ctrPeyemnts";
            this.ctrPeyemnts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ctrPeyemnts.Text = "Wpłaty";
            this.ctrPeyemnts.Click += new System.EventHandler(this.ctrPeyemnts_Click);
            // 
            // accordionControlElementReport
            // 
            this.accordionControlElementReport.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ctrStatMonhtlyDiff});
            this.accordionControlElementReport.Expanded = true;
            this.accordionControlElementReport.Name = "accordionControlElementReport";
            this.accordionControlElementReport.Text = "Raporty";
            // 
            // ctrStatMonhtlyDiff
            // 
            this.ctrStatMonhtlyDiff.Name = "ctrStatMonhtlyDiff";
            this.ctrStatMonhtlyDiff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ctrStatMonhtlyDiff.Text = "Płatności miesięcznie";
            this.ctrStatMonhtlyDiff.Click += new System.EventHandler(this.ctrStatMonhtlyDiff_Click);
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuElementAbout,
            this.menuElementExit});
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Program";
            // 
            // menuElementAbout
            // 
            this.menuElementAbout.Name = "menuElementAbout";
            this.menuElementAbout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuElementAbout.Text = "O programie";
            // 
            // menuElementExit
            // 
            this.menuElementExit.Name = "menuElementExit";
            this.menuElementExit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuElementExit.Text = "Zakończ";
            this.menuElementExit.Click += new System.EventHandler(this.menuElementExit_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(691, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 473);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "Main";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Credi tDemo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementMain;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctrCustomers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctrAgreementActive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuElementAbout;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuElementExit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctrPeyemnts;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctrStatMonhtlyDiff;
    }
}

