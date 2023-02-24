function GetPersons() {
    $.ajax({
        url: "https://localhost:7047/api/Person/GetAll",
        type:"get",          // or method (Get, Post, Put, ...)
        //data:,          // if respone object
        //contentType:,   // data type
        success: function (response) {
            console.log(response);
            //$.map(response, (data) => {
            //    $("#container").append(data.id + " " + data.fullName + " " + data.birthOfDate);
            //})
        }
        //error:
    });
}

function GetPerson(id) {
    id = $("#input-id").val();
    $.ajax({
        url: "https://localhost:7047/api/Person/Get/"+id,
        type: "get",
        success: function (response) {
            console.log(response);
            //JQuery
            $("#input-personId").val(response.id);
            $("#input-personFullName").val(response.fullName);
            $("#input-personBirthOfDate").val(response.birthOfDate);
        }
    });
}

function CreatePerson() {
    var person = {
        id: $("#input-createPersonId").val(),
        fullName: $("#input-createPersonFullName").val(),
        birthOfDate: $("#input-createPersonBirthOfDate").val()
        //id: 5, fullName: "Ali Yılmaz", birthOfDate: "2000-01-01"
    };

    var personJson = JSON.stringify(person);
    console.log(person);

    $.ajax({
        url: "https://localhost:7047/api/Person/Create/",
        method: "post",
        data: personJson,
        contentType: "application/json charset=utf-8",
        success: function (response) {
            console.log("Cevap", response);           
        }
    });
}