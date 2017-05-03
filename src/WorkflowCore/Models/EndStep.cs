﻿using System;
using System.Collections.Generic;
using System.Text;
using WorkflowCore.Interface;

namespace WorkflowCore.Models
{
    public class EndStep : WorkflowStep
    {
        public override Type BodyType => null;

        public override ExecutionPipelineDirective InitForExecution(WorkflowExecutorResult executorResult, WorkflowDefinition defintion, WorkflowInstance workflow, ExecutionPointer executionPointer)
        {
            return ExecutionPipelineDirective.EndWorkflow;
        }
    }
}
