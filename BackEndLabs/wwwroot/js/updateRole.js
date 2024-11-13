const form = document.forms[0];

const roleId = window.location.href.split("/")[5];
const roleUrl = "../../api/ref/policy/role/" + roleId;

document.getElementById("updateHeader1").innerText = `Обновление роли с id: ${roleId}`;

form.addEventListener("submit", (e) => {
    e.preventDefault();

    let updateRoleRequest = {
        name: form["name"].value,
        description: form["description"].value,
    }

    fetch(roleUrl, {
        headers: { "Accept": "application/json", "Content-Type": "application/json"},
        method: "PUT",
        body: JSON.stringify(updateRoleRequest)
    })
        .then(response => {

            if (response.status == 200) {
                window.location.href = "../../roles/" + roleId;
            }

        })
        .catch(error => {
            console.error('Что-то пошло не так', error);
        });

});