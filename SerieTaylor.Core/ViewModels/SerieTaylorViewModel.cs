using MvvmCross.Commands;
using MvvmCross.ViewModels;
using SerieTaylor.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SerieTaylor.Core.ViewModels
{
    public class SerieTaylorViewModel: MvxViewModel
    {
        private double _result;
        private int _numTerms;
        private double _x;
        private readonly ISerieTaylorService _serieTaylorService;
        private MvxCommand _calculateCommand;

        public SerieTaylorViewModel(ISerieTaylorService serieTaylorService)
        {
            _serieTaylorService = serieTaylorService;
        }

        public int NumTerms
        {
            get => _numTerms;
            set => SetProperty(ref _numTerms, value);
        }

        public double X
        {
            get => _x;
            set => SetProperty(ref _x, value);
        }
        public double Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            NumTerms = 0;
            Calculate();
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        private void Calculate()
        {
            Result = _serieTaylorService.GetSerieTaylor(NumTerms, X);
        }
    }
}
