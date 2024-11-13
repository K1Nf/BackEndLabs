const requestLogId = window.location.href.split("/")[4];
const requestLogUrl = "../api/ref/log/request/" + requestLogId;


fetch(requestLogUrl, {
    method: "GET",
    headers: { "Accept": "application/json", "Content-Type": "application/json"/*, "Authorization": "Bearer " + token */ },
})
    .then(response => {
        if (response.status == 200) {
            return response.json();
        }
        throw new Error('Network response was not ok');
    })

    .then(data => {


        console.log(data);
        document.getElementById("id").innerText = data.id;
        document.getElementById("controllerName").innerText = data.controllerName;
        document.getElementById("actionName").innerText = data.actionName;
        document.getElementById("ipAddress").innerText = data.ipAddress;
        document.getElementById("method").innerText = data.method;
        document.getElementById("path").innerText = data.path;


        document.getElementById("requestBody").innerText = data.requestBody ?? "";
        document.getElementById("requestHeaders").innerText = data.requestheaders ?? "";
        document.getElementById("responseBody").innerText = data.responseBody ?? "";
        document.getElementById("responseHeaders").innerText = data.responseHeaders ?? "";


        document.getElementById("statusCode").innerText = data.statusCode;
        document.getElementById("userAgent").innerText = data.userAgent;
        document.getElementById("userId").innerText = data.userId;

    })
    .catch(error => {
        console.error('There was a problem with the fetch operation:', error);
    });
