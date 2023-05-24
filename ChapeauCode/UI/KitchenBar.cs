using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class KitchenBar : Form
    {
        private OrderService orderService = new OrderService();

        public KitchenBar()
        {
            InitializeComponent();
            GetOrderedItemsKitchen();
        }

        private void GetOrderedItemsKitchen()
        {
            FillListViewOrders(lstViewOrders, orderService.GetKitchenOrders());
        }

        //fill the listview with the given menuitems
        private void FillListViewOrders(ListView listView, List<OrderItem> orderItems)
        {
            try
            {

                foreach (OrderItem orderItem in orderItems)
                {
                    ListViewItem listViewItem = new ListViewItem(orderItem.Order.OrderId.ToString());
                    listViewItem.SubItems.Add(orderItem.Comment.ToString());
                    listViewItem.SubItems.Add(orderItem.Quantity.ToString());
                    listViewItem.SubItems.Add(orderItem.MenuItem.Name.ToString());
                    listViewItem.Tag = orderItem;
                    listView.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
