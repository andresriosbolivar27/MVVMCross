using SerieTaylorModified.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace SerieTaylorModified.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<SerieTaylorModifiedViewModel>();
        }
    }
}
