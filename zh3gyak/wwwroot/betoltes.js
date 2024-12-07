

document.getElementById("AddButton").addEventListener("click", () => {
    var newEmp = {
        "name": document.getElementById("name").value,
        "position": document.getElementById("posi").value,
        "email": document.getElementById("email").value,
        "phone": document.getElementById("phone").value,

    }
    fetch("api/employee", {
        method: "POST",
        headers: {
            "Content-type": "application/json"
        },
        body: JSON.stringify(newEmp)
    })

});



fetch("api/employee").then(v => v.json()).then(o => {

    let tbody = document.getElementById("tb_emp");

    console.log("GET:", o);

    o.forEach(e => {
        let tr = document.createElement("tr");
        tr.innerHTML = `
                                            <td>${e.employeeId}</td>
                                            <td>${e.name}</td>
                                            <td>${e.position}</td>
                                            <td>${e.email}</td>
                                            <td>${e.phone}</td>

                                            `;
        tbody.appendChild(tr);
    });
})

