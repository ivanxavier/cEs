function Salvar() {
    var url = "/Faleconosco/Salvar";
    var data = $('form').serialize();
    var valida = true;
    if ($('#Nome').val() == undefined || $('#Nome').val() == "" || $('#Nome').val() == 'null' || $('#Nome').val() == null ||
       $('#Celular').val() == undefined || $('#Celuler').val() == "" || $('#Celular').val() == 'null' || $('#Celular').val() == null ||
       $('#Telefone').val() == undefined || $('#Telefone').val() == "" || $('#Telefone').val() == 'null' || $('#Telefone').val() == null ||
       $('#Email').val() == undefined || $('#Email').val() == "" || $('#Email').val() == 'null' || $('#Email').val() == null ||
       $('#Mensagem').val() == undefined || $('#Mensagem').val() == "" || $('#Mensagem').val() == 'null' || $('#Mensagem').val() == null)
    {
        valida = false;
    };
    if (valida) {
        $.ajax({
            url: url
            , data: data
            , type: "POST"
            , datatype: "html"
            , cache: false
            , async: true
            , success: function (data) {
                alert("E-Mail enviado com sucesso");
                window.location.href = window.location.protocol + '//' + window.location.hostname + ':' + window.location.port + '/Home/Index';
            }
        })
    }
}
