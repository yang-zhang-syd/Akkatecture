﻿using Akkatecture.Commands;

namespace Akkatecture.TestHelpers.Aggregates.Commands
{
    public class TestDomainErrorCommand : Command<TestAggregate, TestId>
    {
        public TestDomainErrorCommand(TestId aggregateId)
            : base(aggregateId)
        {

        }
        
    }
}