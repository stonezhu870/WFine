using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using NFine.Code;
using NFine.Domain.Entity.SystemManage;
using NFine.WinForm.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Forms;

namespace NFine.WinForm
{
    public partial class MyMain : XtraForm
    {
        public MyMain()
        {
            InitSkins();
            InitializeComponent();
        }

        private void InitSkins()
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("");
        }

        //private void loadModule(ModuleEntity moduleEntity)
        //{
        //    try
        //    {
        //        //string appPath = System.Windows.Forms.Application.StartupPath + moduleEntity.F_File;         
        //        byte[] fileData = File.ReadAllBytes(moduleEntity.F_File);
        //        Assembly assembly = Assembly.Load(fileData); // 加载程序集（EXE 或 DLL） 
        //        //Type OneClass = assembly.GetType("Index");
        //        Form form = (Form)assembly.CreateInstance(moduleEntity.F_Class); // 创建类的实例 
                
        //        form.MdiParent = this;
        //        form.Show();
        //    }
        //    catch
        //    {
        //        //throw;
        //    }
        //}

        //private void MyTree_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if (MyTree.FocusedNode == null) return;
        //    //List<ModuleEntity> moduleList = (List<ModuleEntity>)MyTree.DataSource;
        //    ModuleEntity moduleEntity = moduleList[MyTree.FocusedNode.Id];
        //    loadModule(moduleEntity);
        //}

        //private void barSubItem_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    ModuleEntity moduleEntity  = (ModuleEntity) e.Item.Tag;
        //    loadModule(moduleEntity);
        //}

        //private BarSubItem IniMenuParent(ModuleEntity moduleEntity)
        //{
        //    BarSubItem barSubItem = new BarSubItem();
        //    barSubItem.AllowDrawArrow = DefaultBoolean.False;
        //    barSubItem.Caption = moduleEntity.F_FullName;
        //    barSubItem.Name = moduleEntity.F_Id;
        //    BarSubItem barItem = (BarSubItem)MyBar.Items[moduleEntity.F_ParentId];
        //    if (barItem == null)
        //    {
        //        ModuleEntity parentEntity = moduleList.Find(t => t.F_Id == moduleEntity.F_ParentId);
        //        barItem = IniMenuParent(parentEntity);
        //    }
        //    barItem.AllowDrawArrow = DefaultBoolean.False;
        //    barSubItem.Tag = moduleEntity;
        //    barSubItem.ItemClick += new ItemClickEventHandler(barSubItem_ItemClick);
        //    barItem.ItemLinks.Add(barSubItem);
        //    return barSubItem;
        //}


        //private void IniMenu(List<ModuleEntity> moduleList)
        //{
        //    foreach (ModuleEntity moduleEntity in moduleList.Where(t => t.F_ParentId == "0"))
        //    {
        //        BarSubItem barSubItem = new BarSubItem();
        //        barSubItem.AccessibleName = moduleEntity.F_Id;
        //        barSubItem.AllowDrawArrow = DefaultBoolean.False;
        //        barSubItem.Caption = moduleEntity.F_FullName;
        //        barSubItem.Name = moduleEntity.F_Id;
        //        barSubItem.Tag = moduleEntity;
        //        MyMenu.ItemLinks.Add(barSubItem);
        //    }
        //    foreach (ModuleEntity moduleEntity in moduleList.Where(t => t.F_ParentId != "0"))
        //    {
        //        IniMenuParent(moduleEntity);
        //    }
        //}
        //SystemManageClient systemManage = new SystemManageClient();
        //List<ModuleEntity> moduleList;
        private void MyMain_Load(object sender, EventArgs e)
        {
            ////cf79ae6addba60ad018347359bd144d2
            //string passWord = Md5.md5("0000", 32);
            //if (systemManage.CheckLogin("admin", passWord))
            //{
            //    moduleList = systemManage.GetMenuList().ToList();
            //    MyTree.DataSource = moduleList;
            //    MyTree.CollapseAll();
            //    IniMenu(moduleList);


            //}

         string t =   Api.Post("GetListJson");

        }

        private void ShowTree_ItemClick(object sender, ItemClickEventArgs e)
        {
            MyLeft.Visibility = 1 - MyLeft.Visibility;
        }
    }
}