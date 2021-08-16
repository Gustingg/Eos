$('#post_PostContent').on('keyup keydown change', function () {
    var countChar = $('#post_PostContent').val().length;
    document.getElementById("insideProg").style.width = (countChar/2.5) + "%";
});