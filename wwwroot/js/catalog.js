


function getCatalogData(){
    //create a jquery ajax request
    $.ajax({
        url: '/catalog/getCatalog',
        type: 'GET',
        success: function(res){
            for (i=0; i<res.length; i++){
                displayCar(res[i]);
            }
            console.log("Server says ", res);
        },
        error: function(error){
            console.log("Error getting catalog ", error);

        }
    });
}

function displayCar(car){
    var container = $("#catContainer");
    var template = `
    <div class='card col-6'>
        <div class='row'>
            <div class='col-7'>
            <img class="car-img" src='${car.imageURL}'>
            </div>
            <div class="col-5">
                <div class="card-body">
                
                <h5 class="card-title">${car.color} ${car.year} ${car.make}</h5>
                <p class="card-text">${car.description}.<br><br><br> Cylinders: ${car.cyls}<br>
                Horsepower: ${car.hp} <br> Doors: ${car.doors} <br> Mileage: ${car.mileage}
                <br> Seats: ${car.seats} </p>
                <p class="card-text"><small class="text-muted">Daily Price: $${car.dailyPrice} </small></p>

                </div>
            </div>
        </div>
    </div>
    
    `;
    container.append(template);
}




function init(){

    console.log("I'm the catalog page");
    getCatalogData();


}

window.onload = init;