using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkTalk.MVC
{
    public interface IViewMsg
    {
        void SetController(ControllerMsg controller);
        RichTextBox Allmsg
        {
            get; set;
        }
        TextBox UserText
        {
            get; set;
        }
        DataGridView GridUser
        {
            get; set;
        }
        OpenFileDialog File
        {
            get; set;
        }
    }
}
