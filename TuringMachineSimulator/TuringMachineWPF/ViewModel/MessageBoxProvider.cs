using System.Windows;

namespace TuringMachineWPF.ViewModel
{
    public class MessageBoxProvider : IMessageBoxProvider
    {
        public void ShowMessage(string messsage)
        {
            MessageBox.Show(messsage, "Turing Machine Simulator");
        }
    }
}