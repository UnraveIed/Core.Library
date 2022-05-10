using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface ILibraryService
    {
        IDataResult<List<Library>> GetAll();
        IResult Add(Library entity);
        IResult Update(Library entity);
        IResult Delete(Library entity);
        IDataResult<Library> GetById(int id);
        IDataResult<List<Library>> GetByLibraryName(string key);
    }
}
