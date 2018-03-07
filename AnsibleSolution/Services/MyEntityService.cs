using AnsibleSolution.Abstractions;
using AnsibleSolution.Models;
using System;
using System.Collections.Generic;

namespace AnsibleSolution.Services
{
    public class MyEntityService : IMyEntityService
    {
        public void AddEntity(MyEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddListEntitites(IEnumerable<MyEntity> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MyEntity> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public MyEntity GetEntityById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
