$("#btnNuevo").click(function (eve) {
    $("#modal-content").load("/SGR_PROVINCIAS/Create");
});
$(".btnEditar").click(function (eve) {
    $("#modal-content").load("/SGR_PROVINCIAS/Edit/" + $(this).data("id"));
});