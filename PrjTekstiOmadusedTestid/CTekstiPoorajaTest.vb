Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CTekstiPoorajaTest

    <TestMethod()> Public Sub Poorafunktsiooniga_YksSone_VastusPooratudSone()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("woem")
        Assert.AreEqual("meow", vastus)

    End Sub

    <TestMethod()> Public Sub Poorafunktsiooniga_TyhiString_VastusTyhiString()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("meow")
        Assert.AreEqual("woem", vastus)

    End Sub

End Class