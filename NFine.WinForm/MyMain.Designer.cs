namespace NFine.WinForm
{
    partial class MyMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMain));
            this.MyBar = new DevExpress.XtraBars.BarManager(this.components);
            this.MyMenu = new DevExpress.XtraBars.Bar();
            this.MyStatus = new DevExpress.XtraBars.Bar();
            this.ShowTree = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.MyDock = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.MyLeft = new DevExpress.XtraBars.Docking.DockPanel();
            this.MyDock_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.MyTree = new DevExpress.XtraTreeList.TreeList();
            this.F_FullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.MyMdi = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MyBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDock)).BeginInit();
            this.MyLeft.SuspendLayout();
            this.MyDock_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyMdi)).BeginInit();
            this.SuspendLayout();
            // 
            // MyBar
            // 
            this.MyBar.AllowShowToolbarsPopup = false;
            this.MyBar.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MyMenu,
            this.MyStatus});
            this.MyBar.DockControls.Add(this.barDockControlTop);
            this.MyBar.DockControls.Add(this.barDockControlBottom);
            this.MyBar.DockControls.Add(this.barDockControlLeft);
            this.MyBar.DockControls.Add(this.barDockControlRight);
            this.MyBar.DockManager = this.MyDock;
            this.MyBar.Form = this;
            this.MyBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ShowTree});
            this.MyBar.MainMenu = this.MyMenu;
            this.MyBar.MaxItemId = 17;
            this.MyBar.StatusBar = this.MyStatus;
            // 
            // MyMenu
            // 
            this.MyMenu.BarName = "Main menu";
            this.MyMenu.DockCol = 0;
            this.MyMenu.DockRow = 0;
            this.MyMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MyMenu.OptionsBar.DisableClose = true;
            this.MyMenu.OptionsBar.DisableCustomization = true;
            this.MyMenu.OptionsBar.DrawBorder = false;
            this.MyMenu.OptionsBar.DrawDragBorder = false;
            this.MyMenu.OptionsBar.MultiLine = true;
            this.MyMenu.OptionsBar.UseWholeRow = true;
            this.MyMenu.Text = "Main menu";
            // 
            // MyStatus
            // 
            this.MyStatus.BarName = "Status bar";
            this.MyStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.MyStatus.DockCol = 0;
            this.MyStatus.DockRow = 0;
            this.MyStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.MyStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ShowTree)});
            this.MyStatus.OptionsBar.AllowQuickCustomization = false;
            this.MyStatus.OptionsBar.DrawDragBorder = false;
            this.MyStatus.OptionsBar.DrawSizeGrip = true;
            this.MyStatus.OptionsBar.UseWholeRow = true;
            this.MyStatus.Text = "Status bar";
            // 
            // ShowTree
            // 
            this.ShowTree.Id = 16;
            this.ShowTree.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ShowTree.ImageOptions.Image")));
            this.ShowTree.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ShowTree.ImageOptions.LargeImage")));
            this.ShowTree.Name = "ShowTree";
            this.ShowTree.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ShowTree_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.MyBar;
            this.barDockControlTop.Size = new System.Drawing.Size(879, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 589);
            this.barDockControlBottom.Manager = this.MyBar;
            this.barDockControlBottom.Size = new System.Drawing.Size(879, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.MyBar;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 569);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(879, 20);
            this.barDockControlRight.Manager = this.MyBar;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 569);
            // 
            // MyDock
            // 
            this.MyDock.Form = this;
            this.MyDock.MenuManager = this.MyBar;
            this.MyDock.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.MyLeft});
            this.MyDock.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // MyLeft
            // 
            this.MyLeft.Controls.Add(this.MyDock_Container);
            this.MyLeft.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.MyLeft.ID = new System.Guid("8ff8c724-55e9-4750-b73b-a8f333012fb7");
            this.MyLeft.Location = new System.Drawing.Point(0, 20);
            this.MyLeft.Name = "MyLeft";
            this.MyLeft.Options.ShowAutoHideButton = false;
            this.MyLeft.Options.ShowCloseButton = false;
            this.MyLeft.OriginalSize = new System.Drawing.Size(265, 200);
            this.MyLeft.Size = new System.Drawing.Size(265, 569);
            this.MyLeft.Text = "目录";
            // 
            // MyDock_Container
            // 
            this.MyDock_Container.Controls.Add(this.MyTree);
            this.MyDock_Container.Location = new System.Drawing.Point(4, 23);
            this.MyDock_Container.Name = "MyDock_Container";
            this.MyDock_Container.Size = new System.Drawing.Size(256, 542);
            this.MyDock_Container.TabIndex = 0;
            // 
            // MyTree
            // 
            this.MyTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.F_FullName});
            this.MyTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTree.KeyFieldName = "F_Id";
            this.MyTree.Location = new System.Drawing.Point(0, 0);
            this.MyTree.Name = "MyTree";
            this.MyTree.OptionsBehavior.Editable = false;
            this.MyTree.OptionsView.ShowColumns = false;
            this.MyTree.OptionsView.ShowHorzLines = false;
            this.MyTree.OptionsView.ShowIndicator = false;
            this.MyTree.OptionsView.ShowVertLines = false;
            this.MyTree.ParentFieldName = "F_ParentId";
            this.MyTree.Size = new System.Drawing.Size(256, 542);
            this.MyTree.TabIndex = 4;
            //this.MyTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MyTree_MouseDoubleClick);
            // 
            // F_FullName
            // 
            this.F_FullName.Caption = "菜单";
            this.F_FullName.FieldName = "F_FullName";
            this.F_FullName.Name = "F_FullName";
            this.F_FullName.Visible = true;
            this.F_FullName.VisibleIndex = 0;
            // 
            // MyMdi
            // 
            this.MyMdi.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.MyMdi.MdiParent = this;
            // 
            // MyMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 616);
            this.Controls.Add(this.MyLeft);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "MyMain";
            this.Text = "基础框架";
            this.Load += new System.EventHandler(this.MyMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDock)).EndInit();
            this.MyLeft.ResumeLayout(false);
            this.MyDock_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyMdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager MyBar;
        private DevExpress.XtraBars.Bar MyMenu;
        private DevExpress.XtraBars.Bar MyStatus;
        private DevExpress.XtraBars.Docking.DockManager MyDock;
        private DevExpress.XtraBars.Docking.DockPanel MyLeft;
        private DevExpress.XtraBars.Docking.ControlContainer MyDock_Container;
        private DevExpress.XtraTreeList.TreeList MyTree;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraTreeList.Columns.TreeListColumn F_FullName;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MyMdi;
        private DevExpress.XtraBars.BarButtonItem ShowTree;
    }
}