using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PelotonCloneApp.ViewModels
{
    public class ChallengesViewModel : BaseViewModel
    {

        public ChallengesViewModel()
        {
            SelectedcategoryCommand = new Command<string>(OnSelectCategory);

        }

        int selectedCategoryIndex;

        public int SelectedCategoryIndex
        {
            get => selectedCategoryIndex;
            set => SetProperty(ref selectedCategoryIndex, value);
        }

        public Command<string> SelectedcategoryCommand { get; }

        void OnSelectCategory(string index)
        {
            if(int.TryParse(index, out int i))
            {
                SelectedCategoryIndex = i;
            }
        }
    }
}
