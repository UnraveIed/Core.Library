using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category entity)
        {
            _categoryDal.Add(entity);
            return new SuccessResult("Kategori basariyla eklendi");
        }

        public IResult Delete(Category entity)
        {
            _categoryDal.Delete(entity);
            return new SuccessResult("Kategori basariyla silindi");
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<List<Category>> GetByCategoryName(string key)
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(p => p.CategoryName.ToLower().Contains(key.ToLower())));
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p=> p.CategoryId == id));
        }

        public IResult Update(Category entity)
        {
            _categoryDal.Update(entity);
            return new SuccessResult("Kategori basariyla guncellendi");
        }
    }
}
