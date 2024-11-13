

const permissionId = window.location.href.split("/")[4];
const permissionUrl = "../api/ref/policy/permission/" + permissionId;

document.getElementById("permissionId").innerText = permissionId;

fetch(permissionUrl, {
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

        document.getElementById("permissionName").innerText = data.name;
        document.getElementById("permissionDescription").innerText = data.description;
        document.getElementById("permissionCode").innerText = data.code;
        
    })
    .catch(error => {
        console.error('There was a problem with the fetch operation:', error);
    });



document.getElementById("softDeleteRole").addEventListener("click", () => {

    deletePermission(permissionUrl + "/soft");

});

document.getElementById("hardDeleteRole").addEventListener("click", () => {

    deletePermission(permissionUrl);

});



function deletePermission(deletePermissionUrl){

    fetch(deletePermissionUrl, {
        method: "DELETE",
        headers: { "Accept": "application/json", "Content-Type": "application/json"},
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



document.getElementById("updatePermission").addEventListener("click", () => {

    window.location.href = "../permissions/update/" + permissionId;

});