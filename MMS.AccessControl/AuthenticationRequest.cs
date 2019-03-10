using System;

namespace MMS.AccessControl
{
    public class AuthenticationRequest
    {
        public string ReaderId { get; set; }
        public int? MemberId { get; set; }
        public string KeyCode { get; set; }
    }

    public static class AuthenticationResultCodes
    {
        public const int Success = 0;
        public const int Error = 1;
        public const int InvalidReader = 2;
        public const int InvalidKeyCode = 3;
    }

    public class AuthenticationResult
    {
        public int ResultCode { get; set; }
        public Member Member { get; set; }
        public string[] Roles { get; set; }
    }

    public class Member
    {
        public int MemberId { get; set; }
        public string FullName { get; set; }
        public DateTimeOffset JoinedWhen { get; set; }
        public DateTimeOffset ExpiresWhen { get; set; }
    }
}