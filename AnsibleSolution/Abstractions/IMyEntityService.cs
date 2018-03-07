using AnsibleSolution.Models;
using System.Collections.Generic;

namespace AnsibleSolution.Abstractions
{
    public interface IMyEntityService
    {
        IEnumerable<MyEntity> GetAllEntities();

        MyEntity GetEntityById(int id);

        void AddEntity(MyEntity entity);

        void AddListEntitites(IEnumerable<MyEntity> entities);
    }
}
