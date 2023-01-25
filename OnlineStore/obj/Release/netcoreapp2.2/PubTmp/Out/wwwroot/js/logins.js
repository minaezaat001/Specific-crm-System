    // Add Active Class To Page Logins
    function addClassBtnLogins() {
        const btnLognsText = document.querySelector("#checked-btn-login")
                .textContent,
            btnsClick = document.querySelectorAll(".list-logins li a");
        btnsClick.forEach((btn) => {
            if (btnLognsText == "today" && $(btn).hasClass("today")) {
                $(btn).addClass("login-active");
                $("#today").fadeIn("slow").siblings().hide();
            } else if (
                btnLognsText == "searchbyname" &&
                $(btn).hasClass("searchbyname")
            ) {
                $(btn).addClass("login-active");
                $("#byname").fadeIn("slow").siblings().hide();
            } else if (
                btnLognsText == "searchbydate" &&
                $(btn).hasClass("searchbydate")
            ) {
                $(btn).addClass("login-active");
                $("#bydate").fadeIn("slow").siblings().hide();
            }
        });
    }
    addClassBtnLogins();
    //End Add Active Class To Page Logins