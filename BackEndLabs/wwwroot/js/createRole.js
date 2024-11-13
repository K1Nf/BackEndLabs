const form = document.forms[0];


form.addEventListener("submit", (e) => {
    e.preventDefault();

    let createRoleRequest = {
        name: form["name"].value,
        description: form["description"].value,
        code: form["code"].value,
    }


    fetch("/api/ref/policy/role", {
        headers: { "Accept": "application/json", "Content-Type": "application/json"/*, "Authorization": "Bearer " + token */ },
        method: "POST",
        body: JSON.stringify(createRoleRequest)
    })
        .then(data => {

            console.log(data);

        })
        .catch(error => {
            console.error('Что-то пошло не так', error);
        });

});