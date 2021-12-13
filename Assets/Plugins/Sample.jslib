mergeInto(LibraryManager.library,
    {
        InjectionJs: function (url) {
            url = Pointer_stringify(url);
            var s = document.createElement("script");
            s.setAttribute('src', url);
            document.head.appendChild(s);
        },

        PushNotification: function (title, body) {
            title = Pointer_stringify(title);
            body = Pointer_stringify(body);
            Push.create(title, { body: body });
        }
    });