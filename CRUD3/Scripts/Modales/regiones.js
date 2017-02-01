$("#btnNuevo").click(function (eve) {
    $("#modal-content").load("/SGR_REGIONES/Create");
});
$(".btnEditar").click(function (eve) {
    $("#modal-content").load("/SGR_REGIONES/Edit/" + $(this).data("id"));
});