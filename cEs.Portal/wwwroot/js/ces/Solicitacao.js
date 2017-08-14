function Salvar() {
    var url = "/Solicitacao/Salvar";
    alert("Oi");
    var data = $('form').serialize();
    var valida = true;
    if ($('#Nome').val() == undefined || $('#Nome').val() == "" || $('#Nome').val() == 'null' || $('#Nome').val() == null ||
        $('#Endereco').val() == undefined || $('#Endereco').val() == "" || $('#Endereco').val() == 'null' || $('#Endereco').val() == null ||
        $('#Numero').val() == undefined || $('#Numero').val() == "" || $('#Numero').val() == 'null' || $('#Numero').val() == null ||
        $('#Bairro').val() == undefined || $('#Bairro').val() == "" || $('#Bairro').val() == 'null' || $('#Bairro').val() == null ||
        $('#Municipio').val() == undefined || $('#Municipio').val() == "" || $('#Municipio').val() == 'null' || $('#Municipio').val() == null ||
        $('#UF').val() == undefined || $('#UF').val() == "" || $('#UF').val() == 'null' || $('#UF').val() == null ||
        $('#Cep').val() == undefined || $('#Cep').val() == "" || $('#Cep').val() == 'null' || $('#Cep').val() == null ||
        $('#Contato').val() == undefined || $('#Contato').val() == "" || $('#Contato').val() == 'null' || $('#Contato').val() == null ||
        $('#Celular').val() == undefined || $('#Celuler').val() == "" || $('#Celular').val() == 'null' || $('#Celular').val() == null ||
        $('#Telefone').val() == undefined || $('#Telefone').val() == "" || $('#Telefone').val() == 'null' || $('#Telefone').val() == null ||
        $('#Email').val() == undefined || $('#Email').val() == "" || $('#Email').val() == 'null' || $('#Email').val() == null ||
        $('#SolicitacaoStatusId').val() == undefined || $('#SolicitacaoStatusId').val() == "" || $('#SolicitacaoStatusId').val() == 'null' || $('#SolicitacaoStatusId').val() == null ||
        $('#Assunto').val() == undefined || $('#Assunto').val() == "" || $('#Assunto').val() == 'null' || $('#Assunto').val() == null)
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
                window.location.href = window.location.protocol + '//' + window.location.hostname + ':' + window.location.port + '/Solicitacao/Index';
            }
        })
    }
}
