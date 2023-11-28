using System;

namespace PlayWithDI.Services
{
    public interface IAqiService
    {
        int GetAQI(string place, DateTime dateTime);
    }
}