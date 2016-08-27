function openTab(id, title, url) {
    $("ul#ul_menu>li>a.active111").removeClass("active111");
    var currentLiEle = $("a#" + id);
    currentLiEle.addClass("active111");
    parent.addTab(title, url, '', id);
}

function addTab(subtitle, url, icon, id, closable) {
    if ($('#tabs').tabs('exists', subtitle)) {
        $('#tabs').tabs('select', subtitle);
    }
    else {
        if (url.indexOf("startProcessActivity") > -1 && url.indexOf("startNodeName") > -1) {
            var s = url.substring(url.lastIndexOf('=') + 1, url.length);
            url = url.substring(0, url.lastIndexOf('=')) + "=" + encodeURI(encodeURI(s));
        }
        $('#tabs').tabs('add', {
            title: subtitle,
            content: createFrame(url, id),
            closable: (closable == false) ? false : true,
            icon: icon
        });
        tabClose();
    }
}
function createFrame(url, id) {
    if (url.indexOf("http") < 0) {
        var rootPath = getRootPath();
        var strPath = window.document.location.pathname;
        var postPath = strPath.substring(0, strPath.substr(1).indexOf('/') + 1);
        if (rootPath.indexOf(postPath) > -1 && url.indexOf(postPath) > -1) {
            url = url.substr(postPath.length + 1, url.length);
        }
        url = getRootPath() + "/" + url;
    }

    var s = '<iframe frameborder="0" marginheight=0 name="' + id + '" id="' + id + '" src="' + url
			+ '" style="width:100%;height:99.5%;"></iframe>';
    return s;
}

function getRootPath() {
    var strFullPath = window.document.location.href;
    var strPath = window.document.location.pathname;
    var pos = strFullPath.indexOf(strPath);
    var prePath = strFullPath.substring(0, pos);
    var postPath = strPath.substring(0, strPath.substr(1).indexOf('/') + 1);
    return (prePath + postPath);
}
function tabClose() {
    /* 双击关闭TAB选项卡 */
    $(".tabs-inner").dblclick(function () {
        var subtitle = $(this).children(".tabs-closable").text();
        $('#tabs').tabs('close', subtitle);
    })
    /* 为选项卡绑定右键 */
    $(".tabs-inner").bind('contextmenu', function (e) {
        $('#mm').menu('show', {
            left: e.pageX,
            top: e.pageY
        });

        var subtitle = $(this).children(".tabs-closable").text();

        $('#mm').data("currtab", subtitle);
        $('#tabs').tabs('select', subtitle);
        return false;
    });
}
