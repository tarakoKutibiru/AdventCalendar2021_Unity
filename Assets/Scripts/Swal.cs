using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Swal
{
    [DllImport("__Internal")]
    private static extern void InjectionJs(string url);

    [DllImport("__Internal")]
    private static extern void SwalFireBase(string body);

    [DllImport("__Internal")]
    private static extern void SwalFireCustomPosition(string body);

    [DllImport("__Internal")]
    private static extern void SwalFireImage(string imageUrl, string body);

    public Swal()
    {
        #if !UNITY_EDITOR && UNITY_WEBGL
        {
            var url = "https://cdn.jsdelivr.net/npm/sweetalert2@11";
            InjectionJs(url);
        }
        #endif
    }

    public void SwalFireRandom()
    {
        var rand = Random.Range(0, 3);
        if (rand == 0)
        {
            SwalFireBase("Hello World.");
        }
        else if (rand == 1)
        {
            SwalFireCustomPosition("Hello World.");
        }
        else
        {
            var imageUrl = "https://images.pexels.com/photos/1314550/pexels-photo-1314550.jpeg";
            SwalFireImage(imageUrl, "Hello World.");
        }
    }
}
