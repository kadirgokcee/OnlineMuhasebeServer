using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos;

public sealed record TokenRefreshTokenDto(
    string Token,
    string RefreshToken,
    DateTime RefreshTokenExpires);
