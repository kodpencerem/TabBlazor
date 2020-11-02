﻿using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using Tabler.Components.Tables;

namespace Tabler.Components.Tables
{
    public class TableRowBase<TableItem> : TableRowComponentBase<TableItem>
    {
        [Parameter] public ITableRow<TableItem> Table { get; set; }
        [Parameter] public TableItem Item { get; set; }
        [Parameter] public ITableRowActions<TableItem> Actions { get; set; }

        public string GetRowCssClass(TableItem item)
        {
            return "";
            //return new CssBuilder()
            //    .AddClass("")
            //    .AddClass("selected-details", IsSame(Table.SelectedItem, item))
            //    .AddClass("hover-row", Table.DetailsTemplate != null || Table.OnItemSelected.HasDelegate || !Table.OnItemSelected.Equals(default(EventCallback<TableItem>)))
            //    .Build();
        }

        public bool IsSame(TableItem first, TableItem second)
        {
            return EqualityComparer<TableItem>.Default.Equals(first, second);
        }
    }
}