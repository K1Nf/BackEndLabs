const form = document.forms[0];


form.addEventListener("submit", (e) => {
    e.preventDefault();

    let registerDTO = {
        userName: form["userName"].value,
        email: form["email"].value,
        birthday: form["birthday"].value,
        password: form["password"].value,
        c_password: form["c_Password"].value,
    }

    fetch("/api/auth/register", {
        headers: { "Accept": "application/json", "Content-Type": "application/json"/*, "Authorization": "Bearer " + token */},
        method: "POST",
        body: JSON.stringify(registerDTO)
    })
    .then(data => {

        console.log(data);
        
    })
    .catch(error => {
        console.error('Что-то пошло не так', error);
    });

});