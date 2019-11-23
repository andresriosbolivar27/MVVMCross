using MvvmCross.ViewModels;
using QuadraticEquations.Core.Services;
using MvvmCross.Commands;
using System.Windows.Input;

namespace QuadraticEquations.Core.ViewModels
{
    public class QuadraticEcuationsViewModel: MvxViewModel
    {
        private double _a, _b, _c;
        private double _x1;
        private double _x2;

        private readonly IQuadraticEquationService _quadraticEquationService;
        private MvxCommand _calculateCommand;

        public QuadraticEcuationsViewModel(IQuadraticEquationService quadraticEquationService)
        {
            _quadraticEquationService = quadraticEquationService;
        }

        public double A
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }
        public double B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }
        public double C
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }

        public double X1
        {
            get => _x1;
            set => SetProperty(ref _x1, value);
        }
        public double X2
        {
            get => _x2;
            set => SetProperty(ref _x2, value);
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
            double x1, x2;
            _quadraticEquationService.GetQuadraticEquation(A, B, C, out x1, out x2);

            X1 = x1;
            X2 = x2;

        }
    }
}
