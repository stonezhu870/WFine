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
            this.MyDock = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.MyLeft = new DevExpress.XtraBars.Docking.DockPanel();
            this.MyDock_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.MyTree = new DevExpress.XtraTreeList.TreeList();
            this.F_FullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.MyMdi = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.MyBar = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.MyDock)).BeginInit();
            this.MyLeft.SuspendLayout();
            this.MyDock_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyMdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyBar)).BeginInit();
            this.SuspendLayout();
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
            this.MyLeft.Location = new System.Drawing.Point(0, 29);
            this.MyLeft.Name = "MyLeft";
            this.MyLeft.Options.ShowAutoHideButton = false;
            this.MyLeft.Options.ShowCloseButton = false;
            this.MyLeft.OriginalSize = new System.Drawing.Size(265, 200);
            this.MyLeft.Size = new System.Drawing.Size(265, 564);
            this.MyLeft.Text = "目录";
            // 
            // MyDock_Container
            // 
            this.MyDock_Container.Controls.Add(this.MyTree);
            this.MyDock_Container.Location = new System.Drawing.Point(4, 23);
            this.MyDock_Container.Name = "MyDock_Container";
            this.MyDock_Container.Size = new System.Drawing.Size(256, 537);
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
            this.MyTree.Size = new System.Drawing.Size(256, 537);
            this.MyTree.TabIndex = 4;
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
            // MyBar
            // 
            this.MyBar.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.MyBar.DockControls.Add(this.barDockControlTop);
            this.MyBar.DockControls.Add(this.barDockControlBottom);
            this.MyBar.DockControls.Add(this.barDockControlLeft);
            this.MyBar.DockControls.Add(this.barDockControlRight);
            this.MyBar.DockManager = this.MyDock;
            this.MyBar.Form = this;
            this.MyBar.MaxItemId = 0;
            this.MyBar.StatusBar = this.bar3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.MyBar;
            this.barDockControlTop.Size = new System.Drawing.Size(879, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 593);
            this.barDockControlBottom.Manager = this.MyBar;
            this.barDockControlBottom.Size = new System.Drawing.Size(879, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.MyBar;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 564);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(879, 29);
            this.barDockControlRight.Manager = this.MyBar;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 564);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
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
            ((System.ComponentModel.ISupportInitialize)(this.MyDock)).EndInit();
            this.MyLeft.ResumeLayout(false);
            this.MyDock_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyMdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking.DockManager MyDock;
        private DevExpress.XtraBars.Docking.DockPanel MyLeft;
        private DevExpress.XtraBars.Docking.ControlContainer MyDock_Container;
        private DevExpress.XtraTreeList.TreeList MyTree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn F_FullName;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MyMdi;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager MyBar;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}