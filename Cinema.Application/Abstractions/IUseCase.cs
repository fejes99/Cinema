using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Abstractions;

public interface IUseCase<in TRequest, TResponse>
{
    Task<TResponse> Execute(TRequest request);
}

