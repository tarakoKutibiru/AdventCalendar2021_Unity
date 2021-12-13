using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Pushbar
{
    [DllImport("__Internal")]
    private static extern void InjectionMenu();

    [DllImport("__Internal")]
    private static extern void PushbarShowSideMenu();

    public Pushbar()
    {
        var js = "https://cdn.jsdelivr.net/npm/pushbar.js@1.0.0/src/pushbar.min.js";
        Injection.InjectionJs(js);
        var css = "https://cdn.jsdelivr.net/npm/pushbar.js@1.0.0/src/pushbar.min.css";
        Injection.InjectionCSS(css);

        Injection.InjectionCSS("https://oncebot.github.io/pushbar.js/demo.css");

        InjectionMenu();
    }

    public void ShowSideMenu()
    {
        PushbarShowSideMenu();
    }
}
