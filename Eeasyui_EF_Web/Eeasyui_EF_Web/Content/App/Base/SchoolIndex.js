$(function () {
    $("#DataGrid").datagrid({
        url: '/School/GetList',
        method: 'get', //默认是post,不允许对静态文件访问
        width: 'auto',
        height: '100%', //设置固定高度 防止改变页数时拉伸 
        iconCls: 'icon-save',
        dataType: "json",
        fitColumns: false,
        rownumbers: false, //是否加行号 
        pagination: true, //是否显式分页 
        pageSize: 15, //页容量，必须和pageList对应起来，否则会报错 
        pageNumber: 1, //默认显示第几页 
        pageList: [15, 30, 45], //分页中下拉选项的数值 
        //onDblClickRow: onDblClickRow,
        onBeforeLoad: function (param) {          
        },
        onLoadError: function () {
            Utility.ErrorAlert("错误", "数据加载错误");
        },
        columns: [
            [
                { field: 'ck', checkbox: true },
                { field: 'Name', title: "校区名称", width: '200px', sortable: true, halign: 'center' },
                { field: 'Area', title: "面积", width: '100px', sortable: true, halign: 'center' ,align:'right'},               
            ]
        ],
        singleSelect: true, //允许选择多行
        selectOnCheck: true, //true勾选会选择行，false勾选不选择行, 1.3以后有此选项
        checkOnSelect: true //true选择行勾选，false选择行不勾选, 1.3以后有此选项
    });
})