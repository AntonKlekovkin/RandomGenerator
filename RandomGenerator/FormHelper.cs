using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGenerator
{
    internal static class FormHelper
    {
        public static double ConvertToDoubleFromControl(Control control, double defaultValue)
        {
            double ret;

            try
            {
                ret = Convert.ToDouble(control.Text);
            }
            catch
            {
                try
                {
                    ret = Convert.ToDouble(control.Text.Replace('.', ','));
                }
                catch
                {
                    control.Text = Convert.ToString(defaultValue);
                    ret = defaultValue;
                }
            }

            return ret;
        }
    }
}
