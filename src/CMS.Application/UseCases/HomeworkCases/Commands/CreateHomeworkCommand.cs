using CMS.Domain.Entities;
using CMS.Domain.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.UseCases.HomeworkCases.Commands
{
    public class CreateHomeworkCommand : IRequest<ResponseModel>
    {
        public virtual Lesson LessonId { get; set; }
        public string Result { get; set; }
        public int Coin { get; set; }
        public required DateTimeOffset StartDate { get; set; }
        public required DateTimeOffset EndDate { get; set; }
    }
}
