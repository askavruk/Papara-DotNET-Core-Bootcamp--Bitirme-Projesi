// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



const url = `https://localhost:44359/`;


function GetBlokAList() {
    var id = id;
    var myUrl = url + "User/GetBlokAList/";
    $.ajax({
        url: myUrl,
        type: "GET",
        success: function (response) {
            $("####").html(response)
        }
    });
}

function GetBlokBList() {
    var id = id;
    var myUrl = url + "User/GetBlokBList/";
    $.ajax({
        url: myUrl,
        type: "GET",
        success: function (response) {
            $("####").html(response)
        }
    });
}

function GetAllUsers() {
    var id = id;
    var myUrl = url + "User/GetAllUsers/";
    $.ajax({
        url: myUrl,
        type: "GET",
        success: function (response) {
            $("####").html(response)
        }
    });
}
