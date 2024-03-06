Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports PrjTekstiOmadused

<TestClass()> Public Class EkraaniVormTest

    <TestMethod()> Public Sub KontrolliPalindroomi()
        Dim foo As New EkraaniVorm
        Dim vastus = foo.PalindroomVastus(True)

    End Sub

End Class