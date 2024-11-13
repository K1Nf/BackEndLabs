

const userId = window.location.href.split("/")[4];
const userUrl = "../api/ref/user/" + userId + "/role/";

document.getElementById("userId").innerText = userId;

fetch(userUrl, {
    method: "GET",
    headers: { "Accept": "application/json", "Content-Type": "application/json"/*, "Authorization": "Bearer " + token */},
})
    .then(response => {
        if (response.status == 200) {
            return response.json();
        }
        if (response.status == 401) {
            window.location.href = "../Authorize/Login";
        }
        if (response.status == 403) {
            alert("ACCESS DENIED");
        }
        throw new Error('Network response was not ok');
    })

    .then(data => {
        const listOfRoles = document.getElementById("rolesList");
        for (let i of data) {
            var li = document.createElement('li');
            li.style.marginLeft = "2.5%";
            li.innerHTML = i.id + ". " + i.name;
            listOfRoles.appendChild(li);
        }
    })
    .catch(error => {
        console.error('There was a problem with the fetch operation:', error);
    });



document.getElementById("addRole").addEventListener("click", () => {

    let input = document.getElementById("add");
    let roleId = input.value;

    let url = userUrl + roleId;

    MakeRequest(url, "POST");
});

document.getElementById("softDeleteRole").addEventListener("click", () => {

    let input = document.getElementById("soft");
    let roleId = input.value;

    let url = userUrl + roleId;
    MakeRequest(url, "DELETE");
});

document.getElementById("hardDeleteRole").addEventListener("click", () => {

    let input = document.getElementById("hard");
    let roleId = input.value;

    let url = userUrl + roleId;
    MakeRequest(url, "DELETE");
});

document.getElementById("restoreRole").addEventListener("click", () => {

    let input = document.getElementById("restore");
    let roleId = input.value;

    let url = userUrl + roleId;
    MakeRequest(url, "POST");
});


function MakeRequest(userRoleUrl, method) {
    fetch(userRoleUrl, {
        method: method,
        headers: { "Accept": "application/json", "Content-Type": "application/json"/*, "Authorization": "Bearer " + token */},
    })
        .then(response => {
            if (response.status == 200) {
                return response.text();
            }
            if (response.status == 401) {
                alert("Неавтоирзован!");
            }
            if (response.status == 403) {
                alert("ACCESS DENIED");
            }
            throw new Error('Network response was not ok');
        })

        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });
};