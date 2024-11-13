//let orderBy 

document.getElementById("getResult").addEventListener("click", () => {

    const baseUrl = "../api/ref/log/request?";

    let pageNumber = document.getElementById("pageNumber").value;
    let count = document.getElementById("recordCount").value;

    
    let ipAddressFilter = document.getElementById("filterIpAddressInput").value;
    let userIdFilter = document.getElementById("filterUserIdInput").value;
    let statusCodeFilter = document.getElementById("filterStatusCodeInput").value;
    let controllerFilter = document.getElementById("filterControllerInput").value;
    let userAgentFilter = document.getElementById("filterUserAgentInput").value;


    let key1 = document.getElementById("firstSortInput").value;
    let order1 = document.getElementById("sortAsc1").value;

    let key2 = document.getElementById("secondSortInput").value;
    let order2 = document.getElementById("sortAsc2").value;


    let sort1 = {
        orderBy: order1,
        key: key1
    };
    let sort2 = {
        orderBy: order2,
        key: key2
    }

    const orders = [sort1, sort2];



    let sortString = "";
    for (let i = 0; i < orders.length; i++) {

        let o = orders[i];
        sortString += `orders[${i}].key=` + o.key;
        sortString += `&`;
        sortString += `orders[${i}].orderBy=` + o.orderBy;
        sortString += `&`;
    }

    let queryParams = {

        page: pageNumber,
        count: count,
        userId: userIdFilter,
        userAgent: userAgentFilter,
        controllerName: controllerFilter,
        ipAddress: ipAddressFilter,
        statusCode: statusCodeFilter,
    };

    let query = new URLSearchParams(queryParams);

    const queryString = query.toString();
    const url = baseUrl + queryString + "&" + sortString;


    console.log(url);
    fetch(url, {
        method: "GET",
        headers: { "Accept": "application/json", "Content-Type": "application/json"},
    })
        .then(response => {
            if (response.status == 200) {
                return response.json();
            }
            throw new Error('Что-то пошло не так');
        })

        .then(data => {

            console.log(data);
            const tableBody = document.getElementById('tBody');
            while (tableBody.rows.length) {
                tableBody.deleteRow(0);
            }
            
            displayTable(data)

        })

        .catch(error => {
            console.error('Что-то пошло не так', error);
        });
});



function displayTable(data) {
    const tableBody = document.getElementById('tBody');

    for (let log of data) {
        const logId = log.id;

        const tr = document.createElement("tr");
        tableBody.appendChild(tr);


        const td1 = document.createElement("td");
        td1.textContent = logId;
        tr.append(td1);


        const td2 = document.createElement("td");
        td2.textContent = log.path;
        tr.append(td2);


        const td3 = document.createElement("td");
        td3.textContent = log.controllerName;
        tr.append(td3);


        const td4 = document.createElement("td");
        td4.textContent = log.actionName;
        tr.append(td4);


        const td5 = document.createElement("td");
        td5.textContent = log.statusCode;
        tr.append(td5);


        const td6 = document.createElement("td");
        td6.textContent = log.created_at;
        tr.append(td6);


        var buttonManage = document.createElement("button");
        buttonManage.addEventListener("click", async function () {

            const urlTolog = "../requestlog/" + logId;

            makeRequest(urlTolog);
        });
        buttonManage.textContent = "Подробнее";

        const td7 = document.createElement("td");
        td7.appendChild(buttonManage);
        tr.append(td7);
    }

}


async function makeRequest(urlToReqLog) {
    window.location.href = urlToReqLog;
}