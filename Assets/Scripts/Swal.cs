using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Swal
{
    [DllImport("__Internal")]
    private static extern void SwalFireBase(string body);

    [DllImport("__Internal")]
    private static extern void SwalFireCustomPosition(string body);

    [DllImport("__Internal")]
    private static extern void SwalFireImage(string imageUrl, string body);

    [DllImport("__Internal")]
    private static extern void SwalFireYouTube(string videoId);

    [DllImport("__Internal")]
    private static extern void SwalFireGoogleMap();

    public Swal()
    {
        #if !UNITY_EDITOR && UNITY_WEBGL
        {
            var url = "https://cdn.jsdelivr.net/npm/sweetalert2@11";
            Injection.InjectionJs(url);
        }
        #endif
    }

    public void SwalFire(int index)
    {
        if (index == 0)
        {
            SwalFireBase("Hello World.");
        }
        else if (index == 1)
        {
            SwalFireCustomPosition("Hello World.");
        }
        else if (index == 2)
        {
            var imageUrl = "https://images.pexels.com/photos/1314550/pexels-photo-1314550.jpeg";
            SwalFireImage(imageUrl, "Hello World.");
        }
        else if (index == 3)
        {
            SwalFireGoogleMap();
        }
        else
        {
            SwalFireYouTube("jNQXAC9IVRw");
        }
    }
}
