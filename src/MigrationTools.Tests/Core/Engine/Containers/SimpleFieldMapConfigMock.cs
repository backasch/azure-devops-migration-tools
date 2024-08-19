﻿using MigrationTools._EngineV1.Configuration;

namespace MigrationTools.Engine.Containers.Tests
{
    public class SimpleFieldMapConfigMock : IFieldMapOptions
    {
        public string WorkItemTypeName { get; set; }

        public string FieldMap
        {
            get
            {
                return "SimpleFieldMapMock";
            }
        }

        public void SetExampleConfigDefaults()
        {
            throw new System.NotImplementedException();
        }
    }
}