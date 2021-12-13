mergeInto(LibraryManager.library,
    {
        UppyOpenModal: function () {
            var uppy = Uppy.Core().use(Uppy.Dashboard).use(Uppy.Tus, { endpoint: 'https://tusd.tusdemo.net/files/' });
            uppy.getPlugin("Dashboard").openModal();
        }
    });