Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CTekstiOmadusedTest
    <DataRow("aas", 2)>

    <DataTestMethod()> Public Sub LeiaTaisHaalikuteArv_TestideKomplekt(sisend, oodatavVastus)
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused(sisend)
        Dim vastus = testija.IntTaishaalikuteArv

        Assert.AreEqual(oodatavVastus, vastus)
    End Sub

End Class