// Şehir Autocomplete İşlevi
$(document).ready(function () {
    $("#cityInput").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Search/GetCities",
                type: "GET",
                data: { term: request.term },
                success: function (data) {
                    response(data);
                }
            });
        }
    });
});

// İş İlanı Filtreleme
$(".filter-checkbox").on("change", function () {
    let filters = [];
    $(".filter-checkbox:checked").each(function () {
        filters.push($(this).val());
    });

    $.ajax({
        url: "/Search/FilterJobs",
        type: "POST",
        data: { filters: filters },
        success: function (data) {
            $("#jobResults").html(data);
        }
    });
});
