using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftOff.Models;

namespace LiftOff.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        BaseViewModel currentViewModel;


        public MainViewModel() { }
        public MainViewModel(ApplicationManager _model)
        {
            Model = _model;
        }





        #region Accessors 

        public ApplicationManager Model { get; private set; }

        public BaseViewModel CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                currentViewModel = value;

                NotifyPropertyChanged("CurrentViewModel");
            }
        }

        public List<Muscle> ActiveMuscles
        {
            get { return Model.ActiveMuscles; }
        }
        public bool HasActiveMuscles
        {
            get { return ActiveMuscles.Count > 0; }
        }
        public List<Activity> ActiveActivities
        {
            get { return Model.ActiveActivities; }
        }
        public bool HasActiveActivites
        {
            get { return ActiveActivities.Count > 0; }
        }

        #endregion


    }
}
