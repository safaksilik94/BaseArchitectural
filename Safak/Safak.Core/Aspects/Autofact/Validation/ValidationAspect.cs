using Castle.DynamicProxy;
using FluentValidation;
using Safak.Core.CrossCuttingConcerns.Validation;
using Safak.Core.Utilities.Interceptors;
using Safak.Core.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Safak.Core.Aspects.Autofact.Validation
{
    public class ValidationAspect:MethodInterception
    {
        Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if(!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new Exception(AspectMessages.WrongValidationType);
            }
            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation) 
        {
            var validator =(IValidator) Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entites = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entites)
            {
                ValidationTool.Validate(validator, entity);
            }
        }

    }
}
