
document.getElementById("getPermissionStory").addEventListener("click", function () {

    let permissionInput = document.getElementById("permissionId");
    let permissionId = permissionInput.value;

    const url = "../api/ref/policy/permission/" + permissionId + "/story";
    fetch(url, {
        method: "GET",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
    })
        .then(response => {
            if (response.status == 200) {
                return response.json();
            }
            if (response.status == 403) {
                alert("Доступ запрещен!!!");
            }
            throw new Error('Что-то пошло не так');
        })

        .then(data => {

            const tableBody = document.getElementById('permissionTBody');
            while (tableBody.rows.length) {
                tableBody.deleteRow(0); // Прощаемся с первой строкой!
            }
            displayTable(data, tableBody)

        })

        .catch(error => {
            console.error('Что-то пошло не так', error);
        });
});

function displayTable(data, tableBody) {

    for (let change of data) {
        const changeId = change.id;

        const tr = document.createElement("tr");
        tableBody.appendChild(tr);


        const td1 = document.createElement("td");
        td1.textContent = changeId;
        tr.append(td1);


        const td2 = document.createElement("td");
        td2.textContent = change.entityId;
        tr.append(td2);


        const td3 = document.createElement("td");
        td3.style.fontSize = "0.7vw";
        td3.textContent = change.oldValue;
        tr.append(td3);


        const td4 = document.createElement("td");
        td4.style.fontSize = "0.7vw";
        td4.textContent = change.newValue;
        tr.append(td4);



        var buttonManage = document.createElement("button");

        buttonManage.addEventListener("click", async function () {

            const userUrl = "../../api/ref/changes/permissions/" + changeId;// + "/rollback";

            makeRequest(userUrl);
        });
        buttonManage.textContent = "Rollback";


        const td5 = document.createElement("td");
        td5.appendChild(buttonManage);
        tr.append(td5);
    }
}


function makeRequest(userUrl) {

    fetch(userUrl, {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
    })
        .then(response => {

            console.log(response);
        })
}