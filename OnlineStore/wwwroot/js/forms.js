    // Function Show
    function showFormActive() {
        const fromText = document.querySelector("#checked-form").textContent;
        if (fromText === "formadd") {
            $(".form-add").show();
            $(".form-update").hide();
        } else {
            $(".form-add").hide();
            $(".form-update").show();
        }
    }
    showFormActive();