using Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.UserAndCompanyRLFeatures.RemoveByIdUserAndCompanyRL;
public sealed record RemoveByIdUserAndCompanyRLCommand(
    string Id) : ICommand<RemoveByIdUserAndCompanyRLCommandResponse>;