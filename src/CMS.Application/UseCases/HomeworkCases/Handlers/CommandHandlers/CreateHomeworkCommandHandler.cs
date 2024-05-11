using CMS.Application.UseCases.EventCases.Commands;
using CMS.Application.UseCases.HomeworkCases.Commands;
using CMS.Domain.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.UseCases.HomeworkCases.Handlers.CommandHandlers
{
    public class CreateHomeworkCommandHandler : IRequestHandler<CreateHomeworkCommand, ResponseModel>
    {
        public Task<ResponseModel> Handle(CreateHomeworkCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
