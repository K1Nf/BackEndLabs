
const url = "/api/ref/policy/role";
fetch(url, {
    method: "GET",
    headers: { "Accept": "application/json", "Content-Type": "application/json"/*, "Authorization": "Bearer " + token*/ },
})
    .then(response => {
        if (response.status == 200) {
            return response.json();
        }
        if (response.status == 401) {
            
        }
        if (response.status == 403) {
            alert("Доступ запрещен!!!");
        }
        throw new Error('Что-то пошло не так');
    })

    .then(data => {

        displayTable(data)
        
    })

    .catch(error => {
        console.error('Что-то пошло не так', error);
    });

function displayTable(data) {
    const tableBody = document.getElementById('tBody');


    for (let role of data) {
        const roleId = role.id;

        const tr = document.createElement("tr");
        tableBody.appendChild(tr);


        const td1 = document.createElement("td");
        td1.textContent = role.id;
        tr.append(td1);


        const td2 = document.createElement("td");
        td2.textContent = role.name;
        tr.append(td2);


        var buttonManage = document.createElement("button");
        buttonManage.addEventListener("click", async function () {

            const urlToRole = "../roles/" + roleId;

            makeRequest(urlToRole);
        });
        buttonManage.textContent = "Подробнее";

        const td5 = document.createElement("td");
        td5.appendChild(buttonManage);
        tr.append(td5);
    }

}


async function makeRequest(urlToRole) {
    window.location.href = "../../client/" + urlToRole;
}


let input = document.getElementById("restoreRoleId");

document.getElementById("restoreRole").addEventListener("click", () => {

    let urlToRestoreRole = "/api/ref/policy/role/" + input.value + "/restore";
    fetch(urlToRestoreRole, {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json"},
    })
        .then(response => {
            if (response.status == 200) {
                location.reload();
                return response.json();
            }
            if (response.status == 401) {

            }
            if (response.status == 403) {
                alert("Доступ запрещен!!!");
            }
            throw new Error('Что-то пошло не так');
        })

        .catch(error => {
            console.error('Что-то пошло не так', error);
        });
});


document.getElementById("createRole").addEventListener("click", () => {
    window.location.href = "../roles/create";

});