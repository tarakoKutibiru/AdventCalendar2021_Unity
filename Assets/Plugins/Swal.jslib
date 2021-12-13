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

        SwalFireGoogleMap: function () {
            var html = '<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3240.8202441523526!2d139.76492541618532!3d35.68142788019422!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x9c4a57d52503f0a9!2zMzXCsDQwJzUzLjEiTiAxMznCsDQ2JzAxLjYiRQ!5e0!3m2!1sja!2sjp!4v1639408416705!5m2!1sja!2sjp" width="336" height="189" style="border:0;" allowfullscreen="" loading="lazy"></iframe>';
            Swal.fire({
                title: 'GoogleMap',
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