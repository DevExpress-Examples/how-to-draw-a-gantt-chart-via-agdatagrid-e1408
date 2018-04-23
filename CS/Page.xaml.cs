using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
using DevExpress.AgDataGrid;

namespace GanttExample {
    public partial class Page : UserControl {
        public Page() {
            InitializeComponent();
            grid.DataSource = Source.CreateSource();
            grid.Loaded += new RoutedEventHandler(grid_Loaded);
        }

        void grid_Loaded(object sender, RoutedEventArgs e) {
            grid.ApplyTemplate();
            foreach(AgDataGridColumn column in grid.Columns) {
                if(column.FieldName == "Value") continue;
                column.DisplayTemplate = grid.Resources["dt"] as ControlTemplate;
            }
        }
    }
    public class ValConv : IValueConverter {

        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if (value != null && (int)value == 1) return 1;
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }

        #endregion
    }
    public class LineConv : IValueConverter {

        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if (value != null && (int)value == 2) return 1;
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }

        #endregion
    }
    public class Source {
        public int Value { get; set; }
        public int Jan { get; set; }
        public int Feb { get; set; }
        public int Mar { get; set; }
        public int Apr { get; set; }
        public int May { get; set; }
        public int Jun { get; set; }
        public int Jul { get; set; }
        public int Aug { get; set; }
        public int Sep { get; set; }
        public int Oct { get; set; }
        public int Nov { get; set; }
        public int Dec { get; set; }
        public Source(int val, int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12) {
            Value = val;
            Jan = a1;
            Feb = a2;
            Mar = a3;
            Apr = a4;
            May = a5;
            Jun = a6;
            Jul = a7;
            Aug = a8;
            Sep = a9;
            Oct = a10;
            Nov = a11;
            Dec = a12;
        }
        public static List<Source> CreateSource() {
            List<Source> res = new List<Source>();
            res.Add(new Source(1, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            res.Add(new Source(2, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            res.Add(new Source(3, 0, 2, 0, 0, 1, 1, 2, 0, 0, 0, 0, 0));
            res.Add(new Source(4, 0, 1, 2, 0, 2, 0, 2, 0, 0, 0, 0, 0));
            res.Add(new Source(5, 0, 0, 2, 0, 2, 0, 2, 0, 0, 0, 0, 0));
            res.Add(new Source(6, 0, 0, 2, 0, 2, 0, 1, 2, 0, 0, 0, 0));
            res.Add(new Source(7, 0, 0, 2, 0, 2, 0, 0, 2, 0, 0, 0, 0));
            res.Add(new Source(8, 0, 0, 1, 1, 2, 0, 0, 2, 0, 0, 1, 1));
            res.Add(new Source(9, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 2, 0));
            res.Add(new Source(10, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 0));
            res.Add(new Source(11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            return res;

        }
    }

}
