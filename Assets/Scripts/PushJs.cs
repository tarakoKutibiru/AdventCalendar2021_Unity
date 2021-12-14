using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class PushJs
{
    [DllImport("__Internal")]
    private static extern void PushJsPushNotification(string title, string body);

    public PushJs()
    {
        #if !UNITY_EDITOR && UNITY_WEBGL
        {
            var url = "https://cdnjs.cloudflare.com/ajax/libs/push.js/1.0.8/push.min.js";
            Injection.InjectionJs(url);
        }
        #endif
    }

    public void PushNotification()
    {
        PushJsPushNotification("Push.js", "Hello World");
    }
}
