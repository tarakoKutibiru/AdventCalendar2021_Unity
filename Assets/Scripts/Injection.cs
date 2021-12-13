using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public static class Injection
{
    [DllImport("__Internal")]
    public static extern void InjectionJs(string url);

    [DllImport("__Internal")]
    public static extern void InjectionCSS(string url);
}
