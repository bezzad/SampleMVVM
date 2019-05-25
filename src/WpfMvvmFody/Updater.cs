using System;
using System.Windows;
using System.Windows.Input;

namespace WpfMvvmFody
{
    public class Updater : ICommand
    {
        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            MessageBox.Show(parameter?.ToString() ?? "Test");
        }
        
        #endregion
    }
}