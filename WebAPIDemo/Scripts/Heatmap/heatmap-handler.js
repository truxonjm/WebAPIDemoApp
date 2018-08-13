var heatmap;

createHeatmap = function () {
    heatmap = h337.create({
        container: document.getElementById('heatmap'),
        maxOpacity: .7,
        minOpacity: 0,
        blur: .85
    });
}

removeHeatmap = function () {
    $('.heatmap-canvas').remove();
}

updateHeatmap = function () {
    var mapHierarchyString = responseData[lastCampusChosen][lastBuildingChosen][lastFloorChosen].hierarchyName;
    $.ajax({
        url: 'api/ClientLocations?locatedAfterTime=' + from + '&locatedBeforeTime=' + to + '&mapHierarchyString=' + mapHierarchyString,
        context: document.body,
        success: data => {
            var _data = formatData(data, baseMapScale);
            heatmap.setData(_data);
        }
    });
}

$("#floorImage").on('load', function () {
    baseMapScale = document.getElementById('floorImage').height/ mapData['dimension'].length;
    // Recreate heatmap instance to be current map size
    removeHeatmap();
    createHeatmap();
    $('.heatmap-canvas').css({
        "width": "100%",
        "height": "100%"
    })
    updateHeatmap();
});

var formatData = function (data, scale) {
    var data_obj = {};
    var mapData = [];
    var max = 0;
    var min = 1000;
    $.each(data, (key, val) => {
        var timePoint = {
            'x': Math.ceil(val.MapCoordinateX * scale),
            'y': Math.ceil(val.MapCoordinateY * scale),
            'value': Math.floor(1000 / (val.ConfidenceFactor + 1))
        };
        max = (timePoint.value > max) ? timePoint.value : max;
        min = (timePoint.value < min) ? timePoint.value : min;
        mapData.push(timePoint);
    });
    data_obj['count'] = mapData.length;
    data_obj['max'] = max;
    data_obj['min'] = min;
    data_obj['data'] = mapData;
    return data_obj;
}

var stepForeward = function () {
    var mapHierarchyString = responseData[lastCampusChosen][lastBuildingChosen][lastFloorChosen].hierarchyName;
    var url = 'api/ClientLocations?locatedAfterTime=' + from + '&locatedBeforeTime=' + to + '&mapHierarchyString=' + mapHierarchyString;
    $.ajax({
        url: url,
        method: 'GET',
        async: true,
        success: data => {
            if (isPlaying) {
                var _data = formatData(data, baseMapScale);
                from += step;
                to += step;
                heatmap.setData(_data);
                $("#range").data("ionRangeSlider").update({
                    from: from,
                    to: to 
                })
                if (from >= max) {
                    pageOver(1);
                }
            }
        }
    });
}