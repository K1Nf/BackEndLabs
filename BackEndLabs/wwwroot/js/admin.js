


document.getElementById('downloadArchive').addEventListener('click', function () {

    window.location.href = "../api/file/getFilesArchive";
});


document.getElementById('downloadRoles').addEventListener('click', function () {

    window.location.href = "../api/file/getRolesFile";
});


document.getElementById('downloadPermissions').addEventListener('click', function () {

    window.location.href = "../api/file/getPermissionsFile";
});

document.getElementById('loadRolesFile').addEventListener('click', function () {


    const fileInput = document.getElementById("rolesExcel");
    const file = fileInput.files[0];
    const formData = new FormData();
    formData.append('file', file);

    const url = "../api/file/importRolesExcelFile";

    let statusCode = 0;
    fetch(url, {
        method: 'POST',
        body: formData
    })

        .then(response => {
            if (response.status == 400) {
                statusCode = 400;
            }
            response.text()
        })
        .then(data => {
            if (statusCode == 400) {

                alert(data);
            }
        });

});