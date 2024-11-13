
const token = localStorage.getItem("NeToken"); //  getItem.getItem("NeToken");


document.getElementById("me").addEventListener("click", async function (e) {

    window.location.href = "../me";

});



document.getElementById("users").addEventListener("click", async function (e) {

    window.location.href = "../users";

});


document.getElementById("roles").addEventListener("click", async function (e) {

    window.location.href = "../roles";

});


document.getElementById("permissions").addEventListener("click", async function (e) {

    window.location.href = "../permissions";

});

document.getElementById("logreq").addEventListener("click", async function (e) {

    window.location.href = "../requestslogs";

}); 


document.getElementById("userChanges").addEventListener("click", async function (e) {

    window.location.href = "../../usersLogs";

});

document.getElementById("roleChanges").addEventListener("click", async function (e) {

    window.location.href = "../roleslogs";

});

document.getElementById("permissionChanges").addEventListener("click", async function (e) {

    window.location.href = "../permissionslogs";

});


document.getElementById("lab1").addEventListener("click", async function (e) {

    window.location.href = "../info";

});




document.getElementById("logout").addEventListener("click", async function (e) {

    fetch("../api/auth/out", {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json"},
    })
        .then(response => {
            if (response.status == 200) {
                return response.json();
            }
            if (response.status == 401) {
                window.location.href = "../Authorize/Login";
            }
            throw new Error('Network response was not ok');
        })

        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });

    window.location.href = "../Authorize/Login";

});