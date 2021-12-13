mergeInto(LibraryManager.library,
    {
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

        SwalFireYouTube: function (videoId) {
            videoId = Pointer_stringify(videoId);
            var html = '<iframe width="336" height="189" src="https://www.youtube.com/embed/' + videoId + '" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>';
            Swal.fire({
                title: 'YouTube',
                icon: 'info',
                html: html,
                showCloseButton: true,
                showCancelButton: true,
                focusConfirm: false,
            });
        },

        SwalFireBase: function (body) {
            body = Pointer_stringify(body);
            Swal.fire(body);
        }
    });