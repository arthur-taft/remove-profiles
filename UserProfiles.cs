using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace remove_profiles
{
    public record struct UserProfiles
    {
        private string profileRegPath = @"SOFTWARE\Microsoft\Windows NT\Current Version\ProfileList";
        private RegistryKey? profileListKey = Registry.LocalMachine.OpenSubKey(profileRegPath);
    }
}
