$(document).ready(function () {
    // Hover handling
    $("#earringsDropdown, #dropdownlist").hover(
        function () {
            $("#dropdownlist").stop(true, true).show();
        },
        function () {
            $("#dropdownlist").stop(true, true).hide();
        }
    );

    // Click toggle (optional for mobile)
    $("#earringsDropdown").click(function (e) {
        e.preventDefault(); // prevent navigation if it's an <a>
        $("#dropdownlist").toggle();
    });

    $("#modal").hide();

});

$("#login").click(function () {
    $("#modal").css("display", "flex");
    $("#modal").fadeIn();
})

$("#close").click(function () {
    $("#modal").fadeOut();
})

$("#whatsappChatIcon").click(function () {
    window.open("https://wa.me/"+contactNumber+"?text=Hi%20I%20need%20help", "_blank");
})
