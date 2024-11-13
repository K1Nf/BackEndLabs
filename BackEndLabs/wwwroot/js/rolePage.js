
const roleId = window.location.href.split("/")[4];
const roleUrl = "../api/ref/policy/role/" + roleId;

document.getElementById("roleId").innerText = roleId;

fetch(roleUrl, {
    method: "GET",
    headers: { "Accept": "application/json", "Content-Type": "application/json"},
})
    .then(response => {
        if (response.status == 200) {
            return response.json();
        }
        
        throw new Error('Network response was not ok');
    })

    .then(data => {

        document.getElementById("roleName").innerText = data.name;
        document.getElementById("roleDescription").innerText = data.description ?? " ";
        document.getElementById("roleCode").innerText = data.code;

        const permissions = data.permissions;
        const listOfPermissions = document.getElementById("permissionsList");

        for (let i of permissions) {
            var li = document.createElement('li');
            li.style.marginLeft = "2.5%";
            li.innerHTML = i.id + ". " + i.name;
            listOfPermissions.appendChild(li);
        }

    })
    .catch(error => {
        console.error('There was a problem with the fetch operation:', error);
    });





let permissionIdToAdd = document.getElementById("permissionIdToAdd");
let permissionIdToDelete = document.getElementById("permissionIdToDelete");


document.getElementById("addPermission").addEventListener("click", () => {

    let permissionId = permissionIdToAdd.value;
    if (permissionId != undefined) {
        MakeRequest(roleUrl + "/permission/" + permissionId, "POST");
    }
});


document.getElementById("deletePermission").addEventListener("click", () => {

    let permissionId = permissionIdToDelete.value;
    if (permissionId != undefined) {
        MakeRequest(roleUrl + "/permission/" + permissionId, "DELETE");
    }
});





document.getElementById("softDeleteRole").addEventListener("click", () => {

    let url = roleUrl + "/soft";
    MakeRequest(url, "DELETE");
});

document.getElementById("hardDeleteRole").addEventListener("click", () => {

    MakeRequest(roleUrl, "DELETE");
});



function MakeRequest(url1, method1) {
    fetch(url1, {
        method: method1,
        headers: { "Accept": "application/json", "Content-Type": "application/json"/*, "Authorization": "Bearer " + token*/ },
    })
        .then(response => {
            if (response.status == 200) {
                return response.text();
            }
            if (response.status == 401) {
                alert("Неавторизован!");
            }
            if (response.status == 204) {
                window.location.href = "../roles";
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


document.getElementById("updateRole").addEventListener("click", () => {

    window.location.href = "../roles/update/" + roleId;

});