using QuadraticEquations.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace QuadraticEquations.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<QuadraticEcuationsViewModel>();
        }
    }
}
