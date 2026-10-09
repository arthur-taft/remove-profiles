using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace remove_profiles
{
    public class UserProfiles
    {
        private const string profileRegPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\ProfileList";
        private RegistryKey? profileListKey = Registry.LocalMachine.OpenSubKey(profileRegPath);
    }
}
