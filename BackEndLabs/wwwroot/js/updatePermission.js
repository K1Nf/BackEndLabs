const form = document.forms[0];

const permissionId = window.location.href.split("/")[5];
const permissionUrl = "../../api/ref/policy/permission/" + permissionId;

document.getElementById("updateHeader1").innerText = `Обновление разрешения с id: ${permissionId}`;

form.addEventListener("submit", (e) => {
    e.preventDefault();

    let name = form["name"].value;
    let description = form["description"].value;

    let updatePermissionRequest = {
        name: name,
        description: description,
    }

    fetch(permissionUrl, {
        headers: { "Accept": "application/json", "Content-Type": "application/json"},
        method: "PUT",
        body: JSON.stringify(updatePermissionRequest)
    })
        .then(response => {

            if (response.status == 200) {
                window.location.href = "../../permissions/" + permissionId;
            }

        })
        .catch(error => {
            console.error('Что-то пошло не так', error);
        });

});