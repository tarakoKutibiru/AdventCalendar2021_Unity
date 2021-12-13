mergeInto(LibraryManager.library,
    {
        InjectionJs: function (url) {
            url = Pointer_stringify(url);
            var s = document.createElement("script");
            s.setAttribute('src', url);
            document.head.appendChild(s);
        },

        SwalFireCustomPosition: function (body) {
            body = Pointer_stringify(body);
            Swal.fire({
                position: 'top-end',
                icon: 'success',
                title: body,
                showConfirmButton: false,
                timer: 1500
            });
        },

        SwalFireImage: function (imageUrl, body) {
            imageUrl = Pointer_stringify(imageUrl);
            body = Pointer_stringify(body);
            Swal.fire({
                title: body,
                imageUrl: imageUrl
            })
        },

        SwalFireBase: function (body) {
            body = Pointer_stringify(body);
            Swal.fire(body);
        }
    });