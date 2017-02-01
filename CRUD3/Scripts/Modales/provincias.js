$("#btnNuevo").click(function (eve) {
    $("#modal-content").load($("#urlSitio").val() + "SGR_PROVINCIAS/Create");
});
$(".btnEditar").click(function (eve) {
    $("#modal-content").load($("#urlSitio").val() + "SGR_PROVINCIAS/Edit/" + $(this).data("id"));
});