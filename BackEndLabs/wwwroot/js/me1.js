
fetch("../api/auth/me", {
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

        document.getElementById("userName").innerText = data.userName;
        document.getElementById("userEmail").innerText = data.email;
        document.getElementById("userBirthday").innerText = data.birthDate;

        fetch("../api/file/getUserFile", {
            method: "GET",
        })
            .then(response => response.arrayBuffer())
            .then(data => {
                const byteArray = new Uint8Array(data);

                // Создание тега <img> и установка атрибута src
                const img = document.getElementById('userPhoto');
                img.src = 'data:image/jpeg;base64,' + btoa(String.fromCharCode.apply(null, Array.prototype.slice.call(byteArray))); // Замените 'image/jpeg' на соответствующий тип файла
            })
            .catch(error => console.error('Ошибка:', error));
    })
    .catch(error => {
        console.error('There was a problem with the fetch operation:', error);
    });



document.getElementById('uploadImage').addEventListener('click', function () {
    let input = document.getElementById('imageInput'); // Открыть диалог выбора файла
    input.click();
});

document.getElementById('imageInput').addEventListener('change', function (event) {

    const fileInput = document.getElementById("imageInput");
    const file = fileInput.files[0];
    const formData = new FormData();
    formData.append('file', file);

    const url = "../api/file/load";

    let statusCode = 0;
    fetch(url, {
        method: 'POST',
        body: formData
    })

        .then(response => {
            if (response.status == 400) {
                statusCode = 400;
                console.log("code is 400");
                response.text();
            }
            
        })
        .then(data => {
            if (statusCode == 400) {
                console.log(data);
                alert(data);
            }
        });

});



document.getElementById("admin").addEventListener("click", async function (e) {

    window.location.href = "../admin";

});




// Обработчик для кнопки "Скачать изображение"
document.getElementById('downloadImage').addEventListener('click', function () {

    window.location.href = "../api/file/download";
});



let form = document.forms[0];

document.getElementById("showPasswordForm").addEventListener("click", () => {

    if (form.hidden) {
        form.hidden = false;
        console.log(form);
    }
    else {
        form.hidden = true;
    }
});



form.addEventListener("submit", (e) => {

    e.preventDefault();

    let changePasswordDTO = {
        oldPassword: form["oldPassword"].value, 
        newPassword: form["newPassword"].value, 
        }


    fetch("../api/auth/changePassword", {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
        body: JSON.stringify(changePasswordDTO)
    })
        .then(response => {
            if (response.status == 200) {
                return response.text();
            }

            throw new Error('Network response was not ok');
        })

        .then(data => {

            alert(data);
        })
        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });
});



document.getElementById("out_all").addEventListener("click", () => {


    fetch("../api/auth/out_all", {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json" }
    })
        .then(response => {
            if (response.status == 200) {
                window.location.reload();
            }

            throw new Error('Network response was not ok');
        })

        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });
});




document.getElementById("getTokens").addEventListener("click", () => {


    fetch("../api/auth/tokens", {
        method: "GET",
        headers: { "Accept": "application/json", "Content-Type": "application/json" }
    })
        .then(response => {
            if (response.status == 200) {
                return response.json();
            }

            throw new Error('Network response was not ok');
        })
        .then(data => {

            let tokenList = document.getElementById("tokenList");

            for (let token of data) {

                console.log(token);
                let li = document.createElement("li");
                li.innerText = token;
                li.style.fontSize = "14px";
                tokenList.appendChild(li);
            }
        })


        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });
});