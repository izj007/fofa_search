using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace ListViewItemComparer
{
    //class ListViewColumnSorter: IComparer
    //{
    /// <summary>
    /// This class is an implementation of the 'IComparer' interface.
    /// </summary>
    // public class ListViewColumnSorter : IComparer
    //{
    /// <summary>
    /// Author:沈舜聪
    /// CreateDate:2010-07-13
    /// Description:ListView控件排序比较器
    /// </summary>
    public class ListViewItemComparer : IComparer
    {
        private int col = 0;
        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Name,
            ((ListViewItem)y).SubItems[col].Name);
            return returnVal;

        }
    }
}