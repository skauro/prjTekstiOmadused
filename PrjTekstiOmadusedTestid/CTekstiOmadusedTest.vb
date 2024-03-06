Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CTekstiOmadusedTestid
    <DataRow("ttt", 0)>
    <DataRow("aaa", 3)>
    <DataRow("abcddd", 1)>
    <DataRow("aEiOxX", 4)>
    <DataTestMethod()> Public Sub LoeTaishaalikuteArv_MituTesti(sisend, oodatavVastus)
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused(sisend)
        Dim vastus = testija.intTaishaalikuteArv
        Assert.AreEqual(oodatavVastus, vastus)
    End Sub
End Class