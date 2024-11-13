

document.getElementById("getUserStory").addEventListener("click", function () {

    let userInput = document.getElementById("userId");
    let userId = userInput.value;

    const url = "../api/ref/user/" + userId + "/story";
    fetch(url, {
        method: "GET",
        headers: { "Accept": "application/json", "Content-Type": "application/json"},
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

            const tableBody = document.getElementById('userTBody');
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
        td2.textContent = change.entityName;
        tr.append(td2);


        const td3 = document.createElement("td");
        td3.textContent = change.entityId;
        tr.append(td3);


        const td4 = document.createElement("td");
        td4.textContent = change.entityColumn;
        tr.append(td4);


        const td5 = document.createElement("td");
        td5.textContent = change.oldValue;
        tr.append(td5);


        const td6 = document.createElement("td");
        td6.textContent = change.newValue;
        tr.append(td6);

    }
}