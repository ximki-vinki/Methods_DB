using Methods_DB.Infrastructures.Commands;
using Methods_DB.Models;
using Methods_DB.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Methods_DB.ViewModels
{
    internal class MainWIndowViewModel : ViewModel
    {
        public ObservableCollection<CountStandartItems> StandartItems { get; }


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

            int index_item = 1;
            var standartItem = Enumerable.Range(1, 10).Select(i => new StandartItem
            {
                Name1 = $"Name1{index_item++}",
                Name2 = $"Name2{index_item++}",
                Name3 = $"Name3{index_item++}"
            });
            var standartItems = Enumerable.Range(1, 10).Select(i => new CountStandartItems
            {
                Name = $"Спискок {i}",
                Counts = new ObservableCollection<StandartItem>(standartItem)
            }

                );


            StandartItems = new ObservableCollection<CountStandartItems>(standartItems);


        }
    }
}
