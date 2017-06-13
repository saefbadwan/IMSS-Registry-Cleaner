using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace IMSS_Registry_Cleaner.Classes
{
    class RegistryEdit
    {

        private static Int16 _IMSS_SetUpKeyPath(string _IMSS_SubKey)
        {

            if (_IMSS_SubKey.Contains("HKEY_CURRENT_USER") == true)
            {
                return 0;
            }
            else if (_IMSS_SubKey.Contains("HKEY_LOCAL_MACHINE"))
            {
                return 1;
            }
            else if (_IMSS_SubKey.Contains("HKEY_CLASSES_ROOT"))
            {
                return 2;
            }
            else
            {
                return 3;
            }

        }

        public static bool _IMSS_REGISTRY_DELETE(string _IMSS_SubKey, string _IMSS_VALUE)
        {
            if (_IMSS_DELETE_VALUE(_IMSS_SubKey, _IMSS_VALUE) == false)
            {
                if (_IMSS_DELETE_KEY(_IMSS_SubKey, _IMSS_VALUE))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private static bool _IMSS_DELETE_VALUE(string _IMSS_SubKey, string _IMSS_VALUE)
        {
            RegistryKey _IMSS_TARGET_KEY;
            switch (_IMSS_SetUpKeyPath(_IMSS_SubKey))
            {
                case 1:
                    _IMSS_TARGET_KEY = Registry.CurrentUser.OpenSubKey(_IMSS_SubKey.Replace("HKEY_CURRENT_USER\\", "").Replace("HKEY_CURRENT_USER", ""), true);
                    if (_IMSS_TARGET_KEY != null)
                    {
                        _IMSS_TARGET_KEY.DeleteValue(_IMSS_VALUE);
                        _IMSS_TARGET_KEY.Close();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 2:
                    _IMSS_TARGET_KEY = Registry.LocalMachine.OpenSubKey(_IMSS_SubKey.Replace("HKEY_LOCAL_MACHINE\\", "").Replace("HKEY_LOCAL_MACHINE", ""), true);
                    if (_IMSS_TARGET_KEY != null)
                    {
                        _IMSS_TARGET_KEY.DeleteValue(_IMSS_VALUE);
                        _IMSS_TARGET_KEY.Close();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 3:
                    _IMSS_TARGET_KEY = Registry.ClassesRoot.OpenSubKey(_IMSS_SubKey.Replace("HKEY_CLASSES_ROOT\\", "").Replace("HKEY_CLASSES_ROOT", ""), true);
                    if (_IMSS_TARGET_KEY != null)
                    {
                        _IMSS_TARGET_KEY.DeleteValue(_IMSS_VALUE);
                        _IMSS_TARGET_KEY.Close();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
               default:
                    return false;
            }
        }

        private static bool _IMSS_DELETE_KEY(string _IMSS_SubKey, string _IMSS_VALUE)
        {
            switch (_IMSS_SetUpKeyPath(_IMSS_SubKey))
            {
                case 0:
                    return _IMSS_DeleteRegistr(_IMSS_SubKey.Replace("HKEY_CURRENT_USER\\", "").Replace("HKEY_CURRENT_USER", ""),_IMSS_VALUE,0);
                case 1:
                    return _IMSS_DeleteRegistr(_IMSS_SubKey.Replace("HKEY_LOCAL_MACHINE\\", "").Replace("HKEY_LOCAL_MACHINE", ""), _IMSS_VALUE,1);
                case 2:
                    return _IMSS_DeleteRegistr(_IMSS_SubKey.Replace("HKEY_CLASSES_ROOT\\", "").Replace("HKEY_CLASSES_ROOT", ""), _IMSS_VALUE,2);
                default:
                    return false;
            }
        }

        private static bool _IMSS_DeleteRegistr(string _IMSS_SubKey, string _IMSS_VALUE,Int16 _IMSS_REGISTRY_KEY)
        {
            RegistryKey _IMSS_TARGET_KEY = null;

            if (_IMSS_REGISTRY_KEY ==  0)
            {_IMSS_TARGET_KEY = Registry.CurrentUser.OpenSubKey(_IMSS_SubKey,true);}
            else if (_IMSS_REGISTRY_KEY == 1)
            {  _IMSS_TARGET_KEY = Registry.LocalMachine.OpenSubKey(_IMSS_SubKey,true);}
            else if (_IMSS_REGISTRY_KEY == 2)
            { _IMSS_TARGET_KEY = Registry.ClassesRoot.OpenSubKey(_IMSS_SubKey,true);}
            else
            { _IMSS_TARGET_KEY = Registry.CurrentUser.OpenSubKey(_IMSS_SubKey,true); }

            if (_IMSS_TARGET_KEY != null)
            {
                // It's there
                try
                {
                    _IMSS_TARGET_KEY.DeleteSubKey(_IMSS_VALUE);
                }
                catch (InvalidOperationException)
                {
                    try
                    {
                        _IMSS_TARGET_KEY.DeleteSubKeyTree(_IMSS_VALUE);
                    }
                    catch
                    {
                        _IMSS_TARGET_KEY.Close();
                        return false;
                    }

                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
