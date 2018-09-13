Imports System.Net
Imports System.Web.Http


<RoutePrefix("api")>
Public Class ProductController
    Inherits ApiController

    ' GET api/products
    <Route("products")>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"Orange", "Apple"}
    End Function

    ' GET api/products/5
    <Route("products/{id}")>
    Public Function GetValue(ByVal id As Integer) As String
        Return "Apple"
    End Function
End Class
