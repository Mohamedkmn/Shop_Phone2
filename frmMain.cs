using BLLPhoneShop;
using Shop_Phone2.AccessorisLosses;
using Shop_Phone2.AccessorisPurchases;
using Shop_Phone2.AccessorisSales;
using Shop_Phone2.AccessoryProduct;
using Shop_Phone2.Brand;
using Shop_Phone2.Category;
using Shop_Phone2.Clients;
using Shop_Phone2.Global_Classes;
using Shop_Phone2.Login;
using Shop_Phone2.Name_Accessoris;
using Shop_Phone2.People;
using Shop_Phone2.People.Controls;
using Shop_Phone2.Profit_and_Loss_Calculation;
using Shop_Phone2.Supplier;
using Shop_Phone2.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Phone2
{
    public partial class frmMain : Form
    {
        clsUsers _CurrentUser;
        frmLoginScreen _frmLoginScreen;
        bool CLoseApplication;
        public frmMain(frmLoginScreen frmLoginScreen , clsUsers CurrentUser)
        {
            InitializeComponent();
            this._CurrentUser = CurrentUser;
            this._frmLoginScreen = frmLoginScreen;
            CLoseApplication = true;
        }

        private void menuPeople_Click(object sender, EventArgs e)
        {
            if (!clsUtil.UserHasPermission(clsUtil.enPermissions.ShowPeople))
                return;

            frmShowPeopleInfo PeopleInfo = new frmShowPeopleInfo();
            PeopleInfo.ShowDialog();
        }

        private void menuUsers_Click(object sender, EventArgs e)
        {
             if (clsUtil.UserHasPermission(clsUtil.enPermissions.ShowUsers))
            {

                frmShowUsers WokersInfo = new frmShowUsers(frmShowUsers.enOpenFormFor.Show);
                WokersInfo.ShowDialog();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsCurrentUser.SetCurrentUser(this._CurrentUser);

        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            CLoseApplication = false;

            clsCurrentUser.Clear();
            _frmLoginScreen.Show();
            this.Close();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CLoseApplication)
                Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!clsUtil.UserHasPermission(clsUtil.enPermissions.ShowClients))
                return;


            frmShowClient ShowClient = new frmShowClient( frmShowClient.enOpenFormFor.Show);
            ShowClient.ShowDialog();
        }

        private void tsmBrand_Click(object sender, EventArgs e)
        {
            if (!clsUtil.UserHasPermission(clsUtil.enPermissions.ShowBrands))
                return;

            frmShowBrands ShowBrands = new frmShowBrands();
            ShowBrands.ShowDialog();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (!clsUtil.UserHasPermission(clsUtil.enPermissions.ShowAccessoris))
                return;

            frmShowNameAccessoris ShowNameAccessoris = new frmShowNameAccessoris();
            ShowNameAccessoris.ShowDialog();
        }

        private void tsmCategory_Click(object sender, EventArgs e)
        {
            if (!clsUtil.UserHasPermission(clsUtil.enPermissions.ShowCategroies))
                return;

            frmShowCategroies ShowCategroies = new frmShowCategroies();
            ShowCategroies.ShowDialog();


        }
         
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (clsUtil.UserHasPermission(clsUtil.enPermissions.ShowSupplier))
            {
                frmShowSupplier frmShowSupplier = new frmShowSupplier();
                frmShowSupplier.ShowDialog();
            }
         
        }
         
        private void tsmAccessoriesProduct_Click(object sender, EventArgs e)
        {
            if (!clsUtil.UserHasPermission(clsUtil.enPermissions.ShowAccessoriesProducts))
                return;

            frmShowAccessoriesProducts frmAddUpdateNameAccessory = new frmShowAccessoriesProducts(frmShowAccessoriesProducts.enOpenFormFor.Show);

            frmAddUpdateNameAccessory.ShowDialog();
        }

        private void tsmAccessorisPurchases_Click(object sender, EventArgs e)
        {
            if (!clsUtil.UserHasPermission(clsUtil.enPermissions.ShowAccessorisPurchases))
                return;

            frmShowAccessorisPurchases frmAddUpdateclsAccessorisPurchases = new frmShowAccessorisPurchases();
            frmAddUpdateclsAccessorisPurchases.ShowDialog();

        }

        private void tsmAccessorisSales_Click(object sender, EventArgs e)
        {
            if (!clsUtil.UserHasPermission(clsUtil.enPermissions.ShowAccessorisSales))
                return;

            frmShowAccessorisSales frmShowAccessorisSales = new frmShowAccessorisSales();
            frmShowAccessorisSales.ShowDialog();
        }

        private void tsmAccessorisLosses_Click(object sender, EventArgs e)
        {
            frmShowAccessorisLosses frmShowAccessorisLosses = new frmShowAccessorisLosses();
            frmShowAccessorisLosses.ShowDialog();
        }

        private void tsmProfitAndLossCalculation_Click(object sender, EventArgs e)
        {
            if (!clsUtil.UserHasPermission(clsUtil.enPermissions.ProfitAndLossCalculation))
                return;

            frmProfitAndLossCalculation ProfitAndLossCalculation = new frmProfitAndLossCalculation();
            ProfitAndLossCalculation.ShowDialog();
        }

        private void tsmCurrentUserAccountSettings_Click(object sender, EventArgs e)
        {
            frmCurrentUserAccountSettings CurrentUserAccountSettings = new frmCurrentUserAccountSettings();
            CurrentUserAccountSettings.ShowDialog();
        }
    }
}
