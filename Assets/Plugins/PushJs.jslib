mergeInto(LibraryManager.library,
    {
        // Push通知を送る。unityroomの場合は動作しない。
        // UnityのWebGLプレイヤーがiframeでサンドボックス化されているのが理由。
        PushJsPushNotification: function (title, body) {
            title = Pointer_stringify(title);
            body = Pointer_stringify(body);
            Push.create(title, {
                body: body,
                timeout: 5000
            });
        }
    });