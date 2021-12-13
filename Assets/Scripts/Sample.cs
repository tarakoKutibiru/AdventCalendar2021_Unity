using UnityEngine;
using System.Runtime.InteropServices;

public class Sample : MonoBehaviour
{
    Swal swal = default;

    void Awake()
    {
        this.swal = new Swal();
    }

    public void OnSelectedSwalFireButton()
    {
        this.swal.SwalFireRandom();
    }
}
