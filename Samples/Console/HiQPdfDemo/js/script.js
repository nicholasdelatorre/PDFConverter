$(document).ready(function() {
    let url = "http://localhost:56758/api/values";
    $.ajax({
        dataType: "json",
        url: url,
        type: "GET",
        contentType: "application/json; charset=utf-8",
        success: function(json) {

            console.log(json);

        },
        error: function(e) {
            console.log(e);
        }
    });
});