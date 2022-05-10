using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class ManagerManager : IManagerService
    {
        private IManagerDal _managerDal;
        public ManagerManager(IManagerDal managerDal)
        {
            _managerDal = managerDal;
        }

        public IResult Add(Manager entity)
        {
            _managerDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Manager entity)
        {
            _managerDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Manager>> GetAll()
        {
            return new SuccessDataResult<List<Manager>>(_managerDal.GetAll());
        }

        public IDataResult<Manager> GetById(int id)
        {
            return new SuccessDataResult<Manager>(_managerDal.Get(p => p.ManagerId == id));
        }

        public IResult Update(Manager entity)
        {
            _managerDal.Update(entity);
            return new SuccessResult();
        }
    }
}
