@ModelType IndexViewModel
@Code
    ViewBag.Title = "Gerenciar"
End Code

<h2>@ViewBag.Title.</h2>

<p class="text-success">@ViewBag.StatusMessage</p>
<div>
    <h4>Alterar configurações de sua conta</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>Senha:</dt>
        <dd>
            [
            @If Model.HasPassword Then
                @Html.ActionLink("Alterar sua senha", "ChangePassword")
            Else
                @Html.ActionLink("Criar", "SetPassword")
            End If
            ]
        </dd>
        <dt>Logins externos:</dt>
        <dd>
            @Model.Logins.Count [
            @Html.ActionLink("Gerenciar", "ManageLogins") ]
        </dd>
        @*
            Phone Numbers can used as a second factor of verification in a two-factor authentication system.
             
             See <a href="https://go.microsoft.com/fwlink/?LinkId=403804">this article</a>
                for details on setting up this ASP.NET application to support two-factor authentication using SMS.
             
             Uncomment the following block after you have set up two-factor authentication
        *@
        @* 
            <dt>Número de telefone:</dt>
            <dd>
                @(If(Model.PhoneNumber, "None"))
                @If (Model.PhoneNumber <> Nothing) Then
                    @<br />
                    @<text>[&nbsp;&nbsp;@Html.ActionLink("Change", "AddPhoneNumber")&nbsp;&nbsp;]</text>
                    @Using Html.BeginForm("RemovePhoneNumber", "Manage", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                        @Html.AntiForgeryToken
                        @<text>[<input type="submit" value="Remove" class="btn-link" />]</text>
                    End Using
                Else
                    @<text>[&nbsp;&nbsp;@Html.ActionLink("Add", "AddPhoneNumber") &nbsp;&nbsp;]</text>
                End If
            </dd>
        *@
        <dt>Autenticação de dois fatores:</dt>
        <dd>
            <p>
                There are no two-factor authentication providers configured. See <a href="https://go.microsoft.com/fwlink/?LinkId=403804">this article</a>
                for details on setting up this ASP.NET application to support two-factor authentication.
            </p>
            @*
                @If Model.TwoFactor Then
                    @Using Html.BeginForm("DisableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                      @Html.AntiForgeryToken()
                      @<text>
                      Ativado
                      <input type="submit" value="Desativar" class="btn btn-link" />
                      </text>
                    End Using
                Else
                    @Using Html.BeginForm("EnableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                      @Html.AntiForgeryToken()
                      @<text>
                      Desativado
                      <input type="submit" value="Ativar" class="btn btn-link" />
                      </text>
                    End Using
                End If
	     *@
        </dd>
    </dl>
</div>
