
using System.Text.RegularExpressions;

namespace CorteCerto.Domain.Helpers;

public static class PasswordHelper
{
    public static readonly Regex HasUpperAndLowerCaracter = new(@"^(?=.*[a-z])(?=.*[A-Z]).*$", RegexOptions.Compiled);

    public static readonly Regex HasNumber = new(@"^(?=.*\d).*$", RegexOptions.Compiled);

    public static readonly Regex HasSpecialCharacter = new(@"^(?=.*[!@#$%^&*(),.?:{}|<>_\-+=]).*$", RegexOptions.Compiled);
}
