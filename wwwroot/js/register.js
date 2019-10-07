


function save(){

    // get data from the form
    var Make = $("#Make").val();
    var Model = $("#Model").val();
    var Year = $("#Year").val();
    var Price = $("#DailyPrice").val();
    var Seats = $("#Seats").val();
    var Color = $("#Color").val();
    var Mileage = $("#Mileage").val();
    var Image = $("#ImageURL").val();
    var Doors = $("#Doors").val();
    var Cyls = $("#Cyls").val();
    var HP = $("#HP").val();
    var Desc = $("#Description").val();

    $("#divAlert").addClass("hide");
    //perform data validation

    var errorOcurred = false;
    $("#Year").removeClass("error");
    if(!Year || !Number.isInteger(Year * 1)){
        $("#Year").addClass("error");
        errorOcurred = true;
    }
    $("#Price").removeClass("error");
    if(!Price || isNaN(Price)){
        $("#Price").addClass("error");
        errorOcurred = true;
    }
    if(errorOcurred){
        return;
    }



    // create an object

    var car = {

            'Make' : Make,
            'Model' : Model,
            'Year' : Year,
            'DailyPrice' : Price,
            'Seats' : Seats,
            'Color' : Color,
            'Mileage' : Mileage,
            'ImageURL' : Image,
            'Doors' : Doors,
            'Cyls' : Cyls,
            'HP' : HP,
            'Description' : Desc

    };
        
    $.ajax({
        url: '/catalog/savecar',
        type: 'Post',
        contentType: 'application/json',
        data: JSON.stringify(car),
        success: function(res){
            console.log("Response from server", res);
            $("divAlert").removeClass("hide");
            ClearForm();
        },
        error: function(errorDetails){
            console.log("Error from server", errorDetails);

        }

        
    })
       console.log(car); 


    // send the object as a post request
}

function ClearForm()
{
     $("#Make").val("");
    $("#Model").val("");
     $("#Year").val("");
    $("#DailyPrice").val("");
    $("#Seats").val("");
   $("#Color").val("");
  $("#Mileage").val("");
    $("#ImageURL").val("");
  $("#Doors").val("");
    $("#Cyls").val("");
     $("#HP").val("");
    $("#Description").val("");
}


function init(){
    console.log("Register Page");

    //catch click event

    $("#btnSave").click(save);
}




window.onload = init;