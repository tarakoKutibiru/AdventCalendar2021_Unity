using UnityEngine;
using System.Runtime.InteropServices;

public class Sample : MonoBehaviour
{
    Swal swal = default;
    Uppy uppy = default;

    void Awake()
    {
        this.swal = new Swal();
        this.uppy = new Uppy();
    }

    public void OnSelectedSwalFireButton()
    {
        this.swal.SwalFireRandom();
    }

    public void OnSelectedUppyButton()
    {
        this.uppy.OpenModal();
    }
}
