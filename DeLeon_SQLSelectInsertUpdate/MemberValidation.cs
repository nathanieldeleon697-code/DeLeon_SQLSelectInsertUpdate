using System;
namespace DeLeon_SQLSelectInsertUpdate
{
    internal static class MemberValidation
    {
        internal static bool Validate(string student, string first, string middle, string last, string ageText,
            string gender, string program, out long studentId, out int age, out string error)
        {
            studentId = 0; age = 0; error = "";
            if (!long.TryParse(student, out studentId) || studentId <= 0)
                error = "Enter a positive numeric Student ID (up to 19 digits within the BIGINT range).";
            else if (String.IsNullOrWhiteSpace(first) || String.IsNullOrWhiteSpace(last))
                error = "First name and last name are required. Middle name is optional.";
            else if (first.Length > 50 || middle.Length > 50 || last.Length > 50 || program.Length > 50 || gender.Length > 50)
                error = "Names, gender, and program must not exceed 50 characters.";
            else if (!int.TryParse(ageText, out age) || age < 1 || age > 120)
                error = "Enter an age from 1 to 120.";
            else if (String.IsNullOrWhiteSpace(gender) || String.IsNullOrWhiteSpace(program))
                error = "Select a gender and program.";
            return error.Length == 0;
        }
    }
}
