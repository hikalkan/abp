﻿using System.Collections.Generic;
using Abp.Domain.Entities;
using Abp.UI.Inputs;

namespace Abp.DynamicEntityParameters
{
    public class NullDynamicEntityParameterDefinitionManager : IDynamicEntityParameterDefinitionManager
    {
        public static NullDynamicEntityParameterDefinitionManager Instance = new NullDynamicEntityParameterDefinitionManager();

        public void AddAllowedInputType<TInputType>() where TInputType : IInputType
        {
        }

        public IInputType GetOrNullAllowedInputType(string name)
        {
            return null;
        }

        public List<string> GetAllAllowedInputTypeNames()
        {
            return new List<string>();
        }

        public List<IInputType> GetAllAllowedInputTypes()
        {
            return new List<IInputType>();
        }

        public bool ContainsInputType(string name)
        {
            return false;
        }

        public void AddEntity<TEntity, TPrimaryKey>() where TEntity : IEntity<TPrimaryKey>
        {
        }

        public List<string> GetAllEntities()
        {
            return new List<string>();
        }

        public bool ContainsEntity(string entityFullName)
        {
            return false;
        }

        public bool ContainsEntity<TEntity, TPrimaryKey>() where TEntity : IEntity<TPrimaryKey>
        {
            return false;
        }
    }
}