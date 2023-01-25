$(function () {
    // Set Padding Bottom In Body
    if ($("footer").hasClass("bottom")) {
        $("body").css("paddingBottom", $("footer").innerHeight());
    }
    // End Set Padding

    // Start Main Header => Open Nav list
    // Set Var
    const widthNavList = $(".list-nav").innerWidth();
    // Set Width IN list => Hide list
    $(".list-nav").css("left", -widthNavList);

    // Click TO bars => Toogel Navlist
    $(".open-nav-list").click(function () {
        // Class Toogle To list
        $(".list-nav").toggleClass("show");
        // Checked Class Show In Nav List => Show List
        if ($(".list-nav").hasClass("show")) {
            $("body").animate({
                paddingLeft: widthNavList,
            });
            $(".list-nav").animate({
                left: 0,
                opacity: 1,
            });
            // Checked Class Show In Nav List => Hide List
        } else {
            $("body").animate({
                paddingLeft: 0,
            });
            $(".list-nav").animate({
                left: -widthNavList,
                opacity: 0,
            });
        }
    });
    // End Main Header => Open Nav list

    // Start Function Show From Update Products
    $(".table .fa-edit").click(function () {
        $(".form-add").hide();
        $(".form-update").show();
    });

    //  End Function Show From Update Products

    // Start Function Toggle In Logins Page
    $(".list-logins li a").click(function (e) {
        e.preventDefault();
        // Show & Hide Form Lognis To Search
        $($(this).data("targets"))
            .addClass("block")
            .siblings()
            .removeClass("block");
        $($(this).data("targets")).fadeIn("slow").siblings().hide();
        // Add Class In Bnt Click
        $(this).addClass("login-active");
        $(this).parent().siblings().children().removeClass("login-active");
    });

    // End Function Toggle In Logins Page


  
   

