const form = document.forms[0];


form.addEventListener("submit", (e) => {
    e.preventDefault();

    let authorizeDTO = {
        userName: form["userName"].value,
        password: form["password"].value,
    }

    let responseStatus = 0;
    fetch("/api/auth/login", {
        headers: { "Accept": "application/json", "Content-Type": "application/json"/*, "Authorization": "Bearer " + token */ },
        method: "POST",
        body: JSON.stringify(authorizeDTO)
    })
        .then(response => {

            if (response.status == 200) {
                responseStatus = 200;
                window.location.href = "../../me/";
            }
            else {
                return response.text();
            }
        })
        .then(data => {
            if (responseStatus != 200) {
                alert(data);
            }

        }).catch(error => {
            console.error('Ошибка:', error.message);
        });

});