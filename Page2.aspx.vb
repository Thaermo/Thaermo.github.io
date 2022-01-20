
Partial Class Page2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = Request.QueryString("username")
        Label2.Text = Request.QueryString("password")
        
    End Sub
End Class
