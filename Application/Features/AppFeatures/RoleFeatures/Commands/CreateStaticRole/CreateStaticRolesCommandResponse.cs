﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.RoleFeatures.Commands.CreateStaticRole;

public sealed record CreateStaticRolesCommandResponse(
    string Message = "Roller başarıyla oluşturuldu!");
