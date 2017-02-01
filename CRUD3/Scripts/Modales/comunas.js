$("#btnNuevo").click(function (eve) {
    $("#modal-content").load($("#urlSitio").val()+"SGR_COMUNAS/Create");
});
$(".btnEditar").click(function (eve) {
    $("#modal-content").load("/SGR_COMUNAS/Edit/" + $(this).data("id"));
});