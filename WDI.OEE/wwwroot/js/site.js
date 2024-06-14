// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


Number.prototype.padLeft = function (size) {
    var s = String(this);
    while (s.length < (size || 2)) { s = "0" + s; }
    return s;
}

// dd/mm/yyyy hh:MM:ss
function getDateTimeLocalString(d) {
    return dformat =
        [
            (d.getDate() + 1).padLeft(),
            d.getMonth().padLeft(),
            d.getFullYear()
        ].join('/')
        + ' ' +
        [
            d.getHours().padLeft(),
            d.getMinutes().padLeft(),
            d.getSeconds().padLeft()
        ].join(':');
}

// Chỉ có time
function getDateTime_LocalTimeString(d) {
    return dformat =
        [
            d.getHours().padLeft(),
            d.getMinutes().padLeft(),
            d.getSeconds().padLeft()
        ].join(':');
} 

// Có date và time
function getDateTime_LocalDateTimeString(d) {
    var _d = d.toLocaleDateString().split('/');
    return dformat =
        [
            parseInt(_d[1]).padLeft(), // dd
            parseInt(_d[0]).padLeft(), // mm
            parseInt(_d[2]).padLeft() // yyyy
        ].join('-')
    + ' ' +
        [
            d.getHours().padLeft(),
            d.getMinutes().padLeft(),
            d.getSeconds().padLeft()
        ].join(':');
}

function formatDateTime(value, row, index) {
    var _format = 'DD/MM/YYYY hh:mm:ss';
    //let _format = "";
    return moment(value).format(_format);
}


