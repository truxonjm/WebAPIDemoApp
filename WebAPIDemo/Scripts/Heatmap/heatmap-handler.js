var heatmap;

createHeatmap = function () {
    heatmap = h337.create({
        container: document.getElementById('heatmap'),
        maxOpacity: .7,
        minOpacity: 0,
        blur: .85
    });

    $('.heatmap-canvas').css({
        "width": "100%",
        "height": "100%"
    })
}

removeHeatmap = function () {
    $('.heatmap-canvas').remove();
}


$("#floorImage").on('load', function () {
    // Recreate heatmap instance to be current map size
    removeHeatmap();
    createHeatmap();

    $.ajax({
        url: $('#url').val(),
        context: document.body
    }).done(function (data) {
        var _data = formatData(data, baseMapScale);
        heatmap.setData(_data);
    });
});

formatData = function (data, scale) {
    var data_obj = {};
    var mapData = [];
    var max = 0;
    var min = 1000;
    $.each(data, function (key, val) {
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