const form = document.forms[0];


form.addEventListener("submit", (e) => {
    e.preventDefault();

    let createPermissionRequest = {
        name: form["name"].value,
        description: form["description"].value,
        code: form["code"].value,
    }


    fetch("/api/ref/policy/permission", {
        headers: { "Accept": "application/json", "Content-Type": "application/json"},
        method: "POST",
        body: JSON.stringify(createPermissionRequest)
    })
        .then(data => {

            console.log(data);

        })
        .catch(error => {
            console.error('Что-то пошло не так', error);
        });

});