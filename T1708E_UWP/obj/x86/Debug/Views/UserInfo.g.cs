﻿#pragma checksum "C:\Users\Apple\Desktop\UWP_Music_Player\T1708E_UWP\Views\UserInfo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "99B66410B08B4F6E2424B2F055845160"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T1708E_UWP.Views
{
    partial class UserInfo : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\UserInfo.xaml line 12
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element2 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element2).Loaded += this.UserInfo_Loaded;
                }
                break;
            case 3: // Views\UserInfo.xaml line 41
                {
                    this.introduction_content = (global::Windows.UI.Xaml.Documents.Paragraph)(target);
                }
                break;
            case 4: // Views\UserInfo.xaml line 36
                {
                    this.address = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Views\UserInfo.xaml line 32
                {
                    this.phone = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Views\UserInfo.xaml line 28
                {
                    this.email = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Views\UserInfo.xaml line 24
                {
                    this.name = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Views\UserInfo.xaml line 15
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.BtnLogOut_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

