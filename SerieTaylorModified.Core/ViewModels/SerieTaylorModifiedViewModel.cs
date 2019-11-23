using MvvmCross.Commands;
using MvvmCross.ViewModels;
using SerieTaylorModified.Core.Services;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SerieTaylorModified.Core.ViewModels
{
    public class SerieTaylorModifiedViewModel: MvxViewModel
    {
        private double _result;
        private int _numTerms;
        private double _x;
        private readonly ISerieTaylorModifiedService _SerieTaylorModifiedService;
        private MvxCommand _calculateCommand;

        public SerieTaylorModifiedViewModel(ISerieTaylorModifiedService SerieTaylorModifiedService)
        {
            _SerieTaylorModifiedService = SerieTaylorModifiedService;
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
            Result = _SerieTaylorModifiedService.GetSerieTaylorModified(NumTerms, X);
        }
    }
}
