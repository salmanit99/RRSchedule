
$(document).ready(function () {
    LoadData();
});

function LoadData() {
    debugger;
    $.ajax({
        type: "POST",
        url: '../RRSService.asmx/GetUserData',
        contentType: 'application/json; charset=utf-8',
        async: false,
        datatype: "json",
        success: function (result) {
            debugger;
            var jsonData = JSON.parse(result.d);
            $("#MyTable").DataTable({
                "destroy": true,
                "bInfo": true,
                "aaData": jsonData,
                "columns": [
                    {
                        "data": "Email",
                        "bSortable": true,
                        "visible": true,
                        "bwidth": 40,

                    },

                    {
                        "data": "Firstname",
                        "bSortable": true,
                        "visible": true,
                        "bwidth": 20,
                    },
                    {
                        "data": "Lastname",
                        "bSortable": true,
                        "visible": true,
                        "bwidth": 20,
                    },
                    {
                        "data": "Gender",
                        "bSortable": true,
                        "visible": true,
                        "bwidth": 20,
                    },
                    {
                        "data": "IsActive",
                        "bSortable": true,
                        "visible": true,
                        "mRender": function (data, type, full) {
                            if (data == 1) {
                                return "Yes";
                            }
                            else {
                                return "No";
                            }
                        }
                    }
                ]

            });
        }
    });
}