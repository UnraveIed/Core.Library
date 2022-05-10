using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class LibraryManager : ILibraryService
    {
        private ILibraryDal _libraryDal;

        public LibraryManager(ILibraryDal libraryDal)
        {
            _libraryDal = libraryDal;
        }

        public IResult Add(Library entity)
        {
            _libraryDal.Add(entity);
            return new SuccessResult("Kütüphane başarıyla eklendi");
        }

        public IResult Delete(Library entity)
        {
            _libraryDal.Delete(entity);
            return new SuccessResult("Kütüphane başarıyla silindi");
        }

        public IDataResult<List<Library>> GetAll()
        {
            return new SuccessDataResult<List<Library>>(_libraryDal.GetAll());
        }

        public IDataResult<Library> GetById(int id)
        {
            return new SuccessDataResult<Library>(_libraryDal.Get(p=> p.LibraryId == id));
        }

        public IDataResult<List<Library>> GetByLibraryName(string key)
        {
            return new SuccessDataResult<List<Library>>(_libraryDal.GetAll(p => p.LibraryName.ToLower().Contains(key.ToLower())));
        }

        public IResult Update(Library entity)
        {
            _libraryDal.Update(entity);
            return new SuccessResult("Kütüphane başarıyla güncellendi");
        }
    }
}
