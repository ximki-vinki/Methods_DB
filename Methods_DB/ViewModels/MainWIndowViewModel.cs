using Methods_DB.Infrastructures.Commands;
using Methods_DB.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace Methods_DB.ViewModels
{
    internal class MainWIndowViewModel : ViewModel
    {
        #region Title : String Заголовок окна
        /// <summary>Заголовок окна</summary>
        private string _Title = "Заполнение базы данных методик";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Status : string Статус программы
        /// <summary> Статус программы </summary>
        private string _Status = "Готово";
        /// <summary> Статус программы </summary>
        public string Status
        /// <summary> Статус программы </summary>
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
        #endregion

        #region Команды

        #region CloseAppCommand
        public ICommand CloseAppCommand { get; }

        private bool CanCloseAppCommandExecuted(object p) => true;

        private void OnCloseAppCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        #endregion

        #endregion

        public MainWIndowViewModel()
        {
            #region Команды
            CloseAppCommand = new LambdaCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecuted);
            #endregion



        }
    }
}
