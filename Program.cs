namespace WalkTalk
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ViewMsg view = new ViewMsg();
            view.Visible = false;
            ModelMsg model = new ModelMsg();
            ControllerMsg controller = new ControllerMsg(view, model);
            view.ShowDialog();

        }
    }
}