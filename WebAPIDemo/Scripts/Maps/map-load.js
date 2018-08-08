var responseData = [];
var lastCampusChosen = -1;
var lastBuildingChosen = -1;
var lastFloorChosen = -1;
var baseMapScale = 1;

window.onload = function () {
    $("#heat-wrap").hide();
    $.ajax({
        url: "api/MapData",
        context: document.body
    }).done(function (response) {
        responseData = getCampuses(response);
        // The 0 index has a list containing the key and index of each campus, building, and floor. 
        // The dropdowns are populated with these lists of names, then the value is taken from 
        // the dropdown and added to a variable that then populates the next dropdown 
        // with the 0 index of the next level.
        //
        // e.g. C:["Corning Museum of Glass"] is selected: index=2
        //      * Populates next dropdown with the list from [2][0]
        //      B:["Corning Museum of Glass"] is selected: index=1
        //      * Populates next dropdown with the list from [2][1][0]
        //      F:["Museum Second Floor"] is selected: index=3
        //      * [2][1][3] contains the dimension, image, and hierarchyName data for that floor.
        // This data can then be sent to retrieve the image and make the calculations for the data scaling.

        $.each(responseData[0], function (val, text) {
            // Populate the Campus options.
            $('#campus_select').append($('<option></option>').val(val).html(text))
        });
    });    
}

getCampuses = function (response) {
    var campusNames = {};
    var counter = 0;
    var campuses = [];

    $.each(response.campuses, function (key, val) {
        campusNames[++counter] = val.name;
        var campus = getBuildings(val)
        campuses.push(campus);
    });

    campuses.unshift(campusNames);
    return campuses;
}

getBuildings = function (campus) {
    var buildingNames = [];
    var counter = 0;
    var buildings = [];

    $.each(campus.buildingList, function (key, val) {
        buildingNames[++counter] = val.name;
        var building = getFloors(val)
        buildings.push(building);
    });

    buildings.unshift(buildingNames);
    return buildings;
}

getFloors = function (building) {
    var floorNames = [];
    var counter = 0;
    var floors = [];

    $.each(building.floorList, function (key, val) {
        floorNames[++counter] = val.name;
        var floor = {
            'dimension': val.dimension,
            'image': val.image,
            'hierarchyName': val.hierarchyName
        }
        floors.push(floor);
    });

    floors.unshift(floorNames);
    return floors;
}

removeOptions = function (selectbox) {
    for (var i = selectbox.options.length - 1; i > 0; i--) {
        selectbox.remove(i);
    }
}

populateBuildingOptions = function (obj) {
    // Clears any prior options from dropdown.
    removeOptions(document.getElementById("building_select"));
    removeOptions(document.getElementById("floor_select"));
    lastCampusChosen = obj.value;

    // Populate the Building options.
    $.each(responseData[obj.value][0], function (val, text) {
        if (val != 0) {
            $('#building_select').append($('<option></option>').val(val).html(text))
        }
    });
}

populateFloorOptions = function (obj) {
    // Clears any prior options from dropdown.
    removeOptions(document.getElementById("floor_select"));
    lastBuildingChosen = obj.value;

    //Populate the Floor options.
    $.each(responseData[lastCampusChosen][obj.value][0], function (val, text) {
        if (val != 0) {
            $('#floor_select').append($('<option></option>').val(val).html(text))
        }
    });
}

displayMap = function (obj) {
    lastFloorChosen = obj.value;
    mapData = responseData[lastCampusChosen][lastBuildingChosen][lastFloorChosen];
    var CBF = mapData.hierarchyName.split('>');
    $("#heat-wrap").show();
    $.ajax({
        url: "api/FloorImage?mapCampus=" + CBF[0] + "&mapBuilding=" + CBF[1] + "&mapFloor=" + CBF[2],
        context: document.body
    }).done(function (mapSource) {
        var mapImg = document.getElementById('floorImage');
        mapImg.src = mapSource;
        baseMapScale = setBaseMapScale(mapData, mapImg);
        $("#moveable")
            .draggable("enable")
            .css({
                "cursor": "move"
            })
        $("#heat-wrap")
            .css({
                "pointer-events": "inherit",
                "disabled": false
            })
    });
}

setBaseMapScale = function (mapData, mapImg) {
    mapData['dimension']['size'] = Math.max(mapData['dimension'].length, mapData['dimension'].width);
    mapData['scaledImage'] = { 'size': Math.max(mapImg.height, mapImg.width), 'width': mapImg.width, 'height': mapImg.height };
    mapData['baseScale'] = mapData['scaledImage'].size / mapData['dimension'].size;
    return mapData.baseScale;
}