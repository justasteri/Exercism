using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] phone = phoneNumber.Split("-");
        return (phone[0] == "212", phone[1] == "555", phone[2]);
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
    }
}
