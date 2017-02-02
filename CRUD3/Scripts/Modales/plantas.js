$("#btnNuevo").click(function (eve) {
    $("#modal-content").load($("#urlSitio").val() + "SGR_PLANTAS/Create");
});
$(".btnEditar").click(function (eve) {
    $("#modal-content").load($("#urlSitio").val() + "SGR_PLANTAS/Edit/" + $(this).data("id"));
});