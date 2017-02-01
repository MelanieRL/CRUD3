$("#btnNuevo").click(function (eve) {
    $("#modal-content").load($("#urlSitio").val() + "SGR_REGIONES/Create");
});
$(".btnEditar").click(function (eve) {
    $("#modal-content").load($("#urlSitio").val() + "SGR_REGIONES/Edit/" + $(this).data("id"));
});