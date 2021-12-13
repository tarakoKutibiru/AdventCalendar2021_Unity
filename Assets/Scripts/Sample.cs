using UnityEngine;
using System.Runtime.InteropServices;

public class Sample : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void InjectionJs(string url);

    [DllImport("__Internal")]
    private static extern void PushNotification(string title, string body);

    void Awake()
    {
        #if !UNITY_EDITOR && UNITY_WEBGL
        {
            var url = "https://cdnjs.cloudflare.com/ajax/libs/push.js/0.0.11/push.min.js";
            InjectionJs(url);
        }
        #endif
    }

    public void OnSelectedPushNotificationButton()
    {
        PushNotification("Sample", "Hello World!");
    }
}
