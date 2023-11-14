using static System.Windows.Forms.Control;

namespace kdPlugin.Utils.GetFormControls
{
    /// <summary>
    /// 获取界面控件工具类
    /// </summary>
    public static class GetFormControls
    {
        public static Control GetFormControl(Form form,string controlName) {
            ControlCollection cs = form.Controls;
            Control control = null;
            foreach (Control c in cs)
            {
                if (c.Name == controlName) {
                    control = c;
                    break;
                }
            }
            return control;
        }
    }
}
