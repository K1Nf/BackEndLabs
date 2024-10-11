document.getElementById("server").addEventListener("click", async function (e) {
    e.preventDefault();

    const url = "info/server";
    fetch(url, {
        method: "GET",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
    })
        .then(response => {
            if (response.status == 200) {
                return response.json();
            }
            throw new Error('Что-то пошло не так');
        })

        .then(data => {

            let header = document.getElementById("serverInfo");

            let message = `Название сервера: ${data.serverName} \n 
                            Язык программирования: ${data.language} \n 
                            Название фраемворка: ${data.framework} \n `;

            header.innerText = message; 

        })
        .catch(error => {
            console.error('Что-то пошло не так', error);
        });
});


document.getElementById("client").addEventListener("click", async function (e) {
    e.preventDefault();

    const url = "info/client";
    fetch(url, {
        method: "GET",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
    })
        .then(response => {
            if (response.status == 200) {
                return response.json();
            }
            throw new Error('Что-то пошло не так');
        })

        .then(data => {

            let header = document.getElementById("clientInfo");

            let message = `Ip клиента: ${data.ip} \n 
                            UserAgent клиента: ${data.userAgent} \n 
                            Путь: ${data.path} \n `;

            header.innerText = message;

        })
        .catch(error => {
            console.error('Что-то пошло не так', error);
        });
});


document.getElementById("database").addEventListener("click", async function (e) {
    e.preventDefault();

    const url = "info/database";
    fetch(url, {
        method: "GET",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
    })
        .then(response => {
            if (response.status == 200) {
                return response.json();
            }
            throw new Error('Что-то пошло не так');
        })

        .then(data => {
            
            let header = document.getElementById("databaseInfo");

            let message = `Название СУБД: ${data.name} \n 
                            Версия СУБД: ${data.version} \n`;

            header.innerText = message;

        })
        .catch(error => {
            console.error('Что-то пошло не так', error);
        });
});