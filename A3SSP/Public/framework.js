/*
$(document).ready(function () {
    $('#ModalBox').modal('show');
});
*/
/*
function ModalBoxShow() {
    var ModalRefference = document.getElementById('ModalBox');
    ModalRefference.getElementsByClassName("modal-title")[0].innerHTML = "MEHDI";
    var myModal = new bootstrap.Modal(ModalRefference);
    myModal.show();
    ModalRefference.getElementsByClassName("modal-title")[0].innerHTML = null;
}
*/
function ModalBox(Title, Body, Footer) {
    $("#ModalBox .modal-title").html(Title);
    $("#ModalBox .modal-body").html(Body);
    var FooterContent = '<button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>';
    FooterContent += Footer;
    $("#ModalBox .modal-footer").html(FooterContent);
    $("#ModalBox").modal("show");
}
/*
function ModalBoxCreate(title) {
    MB = document.createElement("div");
    MB.setAttribute("class", "modal fade");
    MB.setAttribute("tabindex", "-1");
    MB.innerHTML = '<div class="modal-dialog"><div class="modal-content"><div class="modal-header"><h5 class="modal-title">Modal title</h5><button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button></div><div class="modal-body">...</div><div class="modal-footer"><button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button></div></div></div>';
    document.body.appendChild(MB);
    MB.show();
    alert("4");
}
*/