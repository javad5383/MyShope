
    $("#srchbox").autocomplete({
        minLength: 3,
        source: function (request, response) {
            var search = $("#srchbox").val();
            $.getJSON("/productsMain/SearchBox/?search=" + search,
                function (data) {
                    response(data);
                });
        }
        ,
        select: function (a, b) {

            $("#SelectedId").val(b.item.data);
            $("#srchfrm").submit();
        }

    });
$("#imageZoom").imageZoom({ zoom: 200 });
function changeImg(src) {
    $("#imageZoom").attr('src', src);
    $("#imageZoom").imageZoom({ zoom: 200 });

}
   

