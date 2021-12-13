mergeInto(LibraryManager.library,
    {
        // domを直接操作して要素をつくる.
        InjectionMenu: function () {
            var s = document.createElement("aside");
            s.setAttribute('data-pushbar-id', 'left_menu');
            s.setAttribute('data-pushbar-direction', 'left');

            var menu = document.createElement("ul");
            menu.setAttribute('class', 'menu');

            var menuItems = ['Home', 'Products', 'About', 'Contact', 'Github'];
            menuItems.forEach(function (item, index, array) {
                var li = document.createElement("li");
                var text = document.createTextNode(item);
                li.appendChild(text);
                menu.appendChild(li);
            });

            s.appendChild(menu);
            document.body.appendChild(s);
        },
        PushbarShowSideMenu: function () {
            const pushbar = new Pushbar({
                blur: true,
                overlay: true,
            });

            pushbar.open('left_menu');
        }
    });