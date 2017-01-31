$("#btnNuevo").click(function (eve) {
    $("#modal-content").load("/SGR_PLANTAS/Create");
});
$(".btnEditar").click(function (eve) {
    $("#modal-content").load("/SGR_PLANTAS/Edit/"+$(this).data("id"));
});