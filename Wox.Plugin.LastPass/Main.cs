using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using System.Windows.Forms;
using LastPass;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using Wox.Plugin.LastPass;



namespace Wox.Plugin.LastPass
{
    public class Main : IPlugin
    {
        public static Authenticate form = new Authenticate();

        public void Init(PluginInitContext context)
        {
            form.vault = null;
        }

        public List<Result> Query(Query query)
        {
            if (form.vault == null)
            {
                List<Result> results = new List<Result>();
                results.Add(new Result()
                {
                    Title = "Login to LastPass",
                    SubTitle = "Press Enter to proceed",
                    IcoPath = "Images\\gray.png",
                    Action = e =>
                    {
                        form.Show();
                        return false;
                    }
                });
                return results;
            }
            else
            {
                List<Result> results = new List<Result>();
                for (var i = 0; i < form.vault.Accounts.Length; ++i)
                {
                    var account = form.vault.Accounts[i];
                    if (account.Name.Contains(query.Search) || account.Url.Contains(query.Search))
                    {
                        results.Add(new Result()
                        {
                            Title = account.Name + " - [" + account.Username + "]",
                            SubTitle = account.Url.Replace(query.Search, "[" + query.Search + "]"),
                            IcoPath = "Images\\red.png",
                            Action = e =>
                            {
                                if (e.SpecialKeyState.CtrlPressed)
                                {
                                    Clipboard.SetText(account.Username);
                                }
                                else if (e.SpecialKeyState.ShiftPressed)
                                {
                                    Clipboard.SetText(account.Url);
                                } else
                                {
                                    Clipboard.SetText(account.Password);
                                }
                                return true;
                            }
                        });
                    }
                }
                return results;
            }
        }
    }


}
