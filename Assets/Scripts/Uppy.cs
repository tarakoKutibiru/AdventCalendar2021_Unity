using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Uppy
{
    [DllImport("__Internal")]
    private static extern void UppyOpenModal();

    public Uppy()
    {
        {
            var url = "https://transloadit.edgly.net/releases/uppy/v1.2.0/uppy.min.js";
            Injection.InjectionJs(url);
        }
        {
            var url = "https://transloadit.edgly.net/releases/uppy/v1.2.0/uppy.min.css";
            Injection.InjectionCSS(url);
        }
    }

    public void OpenModal()
    {
        UppyOpenModal();
    }
}
