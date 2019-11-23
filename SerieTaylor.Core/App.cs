using SerieTaylor.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace SerieTaylor.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<SerieTaylorViewModel>();
        }
    }
}
