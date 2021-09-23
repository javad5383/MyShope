
$(document).ready(function () {

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

   
});