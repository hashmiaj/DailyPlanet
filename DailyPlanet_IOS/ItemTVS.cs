﻿using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace DailyPlanet_IOS
{
    internal class ItemTVS : UITableViewSource
    {
        //public static NSString MyCellId = new NSString("cell_id");

        private List<Item> items;

        public ItemTVS(List<Item> items)
        {
            this.items = items;
        }

        public override  UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            /*
            tableView.RegisterClassForCellReuse(typeof(itemTableCell), MyCellId);
            var cell = (itemTableCell) tableView.DequeueReusableCell("cell_id", indexPath);


            var item = items[indexPath.Row];

            cell.UpdateCell(item);
            */


            var cell = tableView.DequeueReusableCell("cell_id");

            var data = items[indexPath.Row];
            cell.TextLabel.Text = data.itemName;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return items.Count;
        }
    }
}