using UnityEngine;
using System.Runtime.InteropServices;

public class Sample : MonoBehaviour
{
    Swal    swal    = default;
    Uppy    uppy    = default;
    Pushbar pushBar = default;
    PushJs  pushJs  = default;

    void Awake()
    {
        this.swal    = new Swal();
        this.uppy    = new Uppy();
        this.pushBar = new Pushbar();
        this.pushJs  = new PushJs();
    }

    public void OnSelectedSwalFireButton(int index)
    {
        this.swal?.SwalFire(index);
    }

    public void OnSelectedUppyButton()
    {
        this.uppy?.OpenModal();
    }

    public void OnSelectedPushBarButton()
    {
        this.pushBar?.ShowSideMenu();
    }

    public void OnSelectedPushNotificationButton()
    {
        this.pushJs?.PushNotification();
    }
}
