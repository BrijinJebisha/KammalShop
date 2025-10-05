$(document).ready(function () {
    let isDropdownVisible = false;

    $("#earringsDropdown").click(function (e) {
        e.preventDefault();

        if (!isDropdownVisible) {
            $("#dropdownlist").stop(true, true).slideDown(200);
            isDropdownVisible = true;
        } else {
            $("#dropdownlist").stop(true, true).slideUp(200);
            isDropdownVisible = false;
        }
    });

    let isDropdownVisible1 = false;

    $("#userProfile").click(function (e) {
        e.preventDefault();

        if (!isDropdownVisible1) {
            $("#dropdownlist1").stop(true, true).slideDown(200);
            isDropdownVisible1 = true;
        } else {
            $("#dropdownlist1").stop(true, true).slideUp(200);
            isDropdownVisible1 = false;
        }
    });
    // Hover handling
    //$("#earringsDropdown, #dropdownlist").hover(
    //    function () { $("#dropdownlist").stop(true, true).show(); },
    //    function () { $("#dropdownlist").stop(true, true).hide(); }
    //);

    //// Click toggle (for mobile)
    //$("#earringsDropdown").click(function (e) {
    //    e.preventDefault();
    //    $("#dropdownlist").toggle();
    //});

    //$("#userProfile, #dropdownlist1").hover(
    //    function () { $("#dropdownlist1").stop(true, true).show(); },
    //    function () { $("#dropdownlist1").stop(true, true).hide(); }
    //);

    //$("#userProfile").click(function (e) {
    //    e.preventDefault();
    //    $("#dropdownlist1").toggle();
    //});

    $("#modal").hide();

    // Load partial and then bind events
    $("#overviewContainer").load("/Home/OverView", function () {
        bindCardEvents();
    });

    function bindCardEvents() {
        $(".card").each(function () {
            let $card = $(this);
            let $star = $(this);

            $card.find(".btnAdd").click(function () {
                console.log("Add btn clicked...");
                $card.find(".btnAddDiv").hide();
                $card.find(".btnCountDiv").css("display", "flex");
                $card.find(".count").text(1);
            });

            $card.find(".btnPlus").click(function () {
                console.log("clicked");
                let qty = parseInt($card.find(".count").text());
                $card.find(".count").text(qty + 1);
            });

            $card.find(".btnMinus").click(function () {
                console.log("Minus clicked");
                let qty = parseInt($card.find(".count").text());
                if (qty <= 1) {
                    $card.find(".btnCountDiv").hide();
                    $card.find(".btnAddDiv").show();
                    $card.find(".count").text(0);
                } else {
                    $card.find(".count").text(qty - 1);
                }
            });

            $star.find(".ratingIcon").click(function () {
                $star.find(".ratingIcon").css("color", "#FFD700");
            });
        });
    }


    $("#login").click(function () {
        $("#modal-body").html($("#loginContent").html());
        $("#modal").css("display", "flex").fadeIn();
    });

    $(document).on("click", "#btnRegister", function () {
        $("#modal-body").html($("#registerContent").html());
    });

    $("#close").click(function () {
        $("#modal").fadeOut();
    });

    //$("#whatsappChatIcon").click(function () {
    //    window.open("https://wa.me/" + contactNumber + "?text=Hi%20I%20need%20help", "_blank");
    //});

    $("#whatsappChatIcon").click(function () {
        $("#chatwindow").css("display", "flex").fadeIn();
    });
    $("#close1").click(function () {
        $("#chatwindow").fadeOut();
    });

    $("#btnSend").click(function () {
        var message = $("#querybox").val().trim();
        if (message === "") {
            alert("Please enter a message!");
        }
        else {
            window.open(`https://wa.me/${contactNumber}?text=${encodeURIComponent(message)}`, "_blank");
            $("#chatwindow").fadeOut();
        }
        
    });
});

//$(document).ready(function () {
//    // Hover handling
//    $("#earringsDropdown, #dropdownlist").hover(
//        function () {
//            $("#dropdownlist").stop(true, true).show();
//        },
//        function () {
//            $("#dropdownlist").stop(true, true).hide();
//        }
//    );

//    // Click toggle (optional for mobile)
//    $("#earringsDropdown").click(function (e) {
//        e.preventDefault(); // prevent navigation if it's an <a>
//        $("#dropdownlist").toggle();
//    });

//    $("#modal").hide();

//    //$(document).on('click', '.btnAdd', function () {
//    //    const card = $(this).closest('.card');
//    //    const count = card.find('.count');
//    //    card.find('.btnAddDiv').hide();
//    //    card.find('.btnCountDiv').show();
//    //    count.text(1);
//    //})

//    $("#overviewContainer").load("/Home/OverView", function () {
//        bindCardEvents();
//    });

//    function bindCardEvents() {
//        $(".card").each(function () {
//            let $card = $(this);
//            let count = 0;
//            let $star = $(this);

//            $card.find(".btnAdd").click(function () {
//                console.log("Add btn clicked...")
//                $card.find(".btnAddDiv").css("display", "none");
//                $card.find(".btnCountDiv").css("display", "flex");
//                count++;
//                $card.find(".count").text(count);
//            })

//            $card.find(".btnPlus").click(function () {
//                console.log("clicked");
//                count++;
//                $card.find(".count").text(count);

//            });

//            $card.find(".btnMinus").click(function () {
//                console.log("Minusclicked");
//                if (count <= 1) {
//                    count--;
//                    $card.find(".btnCountDiv").css("display", "none");
//                    $card.find(".btnAddDiv").css("display", "flex");
//                }
//                else {
//                    count--;
//                    $card.find(".count").text(count);
//                }
//            });

//            $star.find(".ratingIcon").click(function () {
//                $star.find(".ratingIcon").css("color", "#FFD700");
//            });
//        });
//    }

    

//});

//$("#login").click(function () {
//    $("#modal-body").html($("#loginContent").html());
//    $("#modal").css("display", "flex");
//    $("#modal").fadeIn();
//})

//$(document).on("click", "#btnRegister",function () {
//    $("#modal-body").html($("#registerContent").html());
//})

//$("#close").click(function () {
//    $("#modal").fadeOut();
//})

//$("#whatsappChatIcon").click(function () {
//    window.open("https://wa.me/"+contactNumber+"?text=Hi%20I%20need%20help", "_blank");
//})




