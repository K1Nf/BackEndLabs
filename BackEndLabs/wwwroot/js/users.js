
const url = "../api/ref/user";
fetch(url, {
    method: "GET",
    headers: { "Accept": "application/json", "Content-Type": "application/json"},
})
    .then(response => {
        if (response.status == 200) {
            return response.json();
        }
        if (response.status == 401) {
            //window.location.href = "../../Authorize/Login";
        }
        if (response.status == 403) {
            alert("Доступ запрещен!!!");
        }
        throw new Error('Что-то пошло не так');
    })

    .then(data => {

        console.log(data);
        let tableBody = document.getElementById("usersTable");
        for (let i = 0; i < data.length; i++) {

            const tr = document.createElement("tr");
            tableBody.appendChild(tr);


            const td1 = document.createElement("td");
            td1.textContent = data[i].id;
            tr.append(td1);


            const td2 = document.createElement("td");
            td2.textContent = data[i].userName;
            tr.append(td2);


            var buttonManage = document.createElement("button");

            let userId = data[i].id;
            console.log(userId);
            buttonManage.addEventListener("click", async function () {

                const userUrl = "../../api/ref/user/" + userId + "/role";

                makeRequest(userUrl, userId);
                console.log(userUrl);
            });
            buttonManage.textContent = "Подробнее";
            
            const td3 = document.createElement("td");
            td3.appendChild(buttonManage);
            tr.append(td3);
        }
    })

    .catch(error => {
        console.error('Что-то пошло не так', error);
    });



async function makeRequest(urll, userId) {

    window.location.href = "../../users/" + userId;
}