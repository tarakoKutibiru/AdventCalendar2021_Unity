using UnityEngine;
using System.Runtime.InteropServices;

public class Sample : MonoBehaviour
{
    Swal    swal    = default;
    Uppy    uppy    = default;
    Pushbar pushBar = default;

    void Awake()
    {
        this.swal    = new Swal();
        this.uppy    = new Uppy();
        this.pushBar = new Pushbar();
    }

    public void OnSelectedSwalFireButton()
    {
        this.swal?.SwalFireRandom();
    }

    public void OnSelectedUppyButton()
    {
        this.uppy?.OpenModal();
    }

    public void OnSelectedPushBarButton()
    {
        this.pushBar?.ShowSideMenu();
    }
}
