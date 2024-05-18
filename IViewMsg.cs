using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkTalk
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
    }
}
