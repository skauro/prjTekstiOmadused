Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class PalindroomTest

    <TestMethod()> Public Sub KontrolliPaliondroom_SonaAnna_VastusToene()
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused("anna")
        Dim vastus = testija.boolPalindroom
        Assert.IsTrue(vastus)
    End Sub

End Class