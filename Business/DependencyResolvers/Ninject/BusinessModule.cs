using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.ADONET;
using DataAccess.Concretes.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBookService>().To<BookManager>().InSingletonScope();
            Bind<IBookDal>().To<EfBookDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<ILibraryService>().To<LibraryManager>().InSingletonScope();
            Bind<ILibraryDal>().To<EfLibraryDal>().InSingletonScope();

            Bind<IMyBookListService>().To<MyBookListManager>().InSingletonScope();
            Bind<IMyBookListDal>().To<AdoMyBookListDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();

            Bind<IManagerService>().To<ManagerManager>().InSingletonScope();
            Bind<IManagerDal>().To<EfManagerDal>().InSingletonScope();

            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();
        }
    }
}
