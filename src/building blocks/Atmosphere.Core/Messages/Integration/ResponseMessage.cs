using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atmosphere.Core.Messages.Integration
{
    public class ResponseMessage : Message
    {
        public ValidationResult ValidationResult  { get; set; }

        public ResponseMessage(ValidationResult validationResult)
        {
            ValidationResult = validationResult;
        }
    }
}
